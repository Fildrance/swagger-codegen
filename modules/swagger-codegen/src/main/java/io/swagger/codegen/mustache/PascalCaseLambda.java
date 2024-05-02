package io.swagger.codegen.mustache;

import com.samskivert.mustache.Mustache;
import com.samskivert.mustache.Template;
import io.swagger.codegen.CodegenConfig;
import io.swagger.codegen.DefaultCodegen;

import java.io.IOException;
import java.io.Writer;

/**
 * Converts text in a fragment to PascalCase.
 *
 * Register:
 * <pre>
 * additionalProperties.put("pascalcase", new PascalCaseLambda());
 * </pre>
 *
 * Use:
 * <pre>
 * {{#pascalcase}}{{name}}{{/pascalcase}}
 * </pre>
 */
public class PascalCaseLambda implements Mustache.Lambda {
    private CodegenConfig generator = null;
    private Boolean escapeParam = false;

    public PascalCaseLambda() {

    }

    public PascalCaseLambda generator(final CodegenConfig generator) {
        this.generator = generator;
        return this;
    }

    public PascalCaseLambda escapeAsParamName(final Boolean escape) {
        this.escapeParam = escape;
        return this;
    }

    @Override
    public void execute(Template.Fragment fragment, Writer writer) throws IOException {
        String text = DefaultCodegen.camelize(fragment.execute(), false);
        if (generator != null) {
            text = generator.sanitizeName(text);
            if (generator.reservedWords().contains(text)) {
                // Escaping must be done *after* camelize, because generators may escape using characters removed by camelize function.
                text = generator.escapeReservedWord(text);
            }

            if (escapeParam) {
                // NOTE: many generators call escapeReservedWord in toParamName, but we can't assume that's always the case.
                //       Here, we'll have to accept that we may be duplicating some work.
                text = generator.toParamName(text);
            }
        }
        writer.write(text);
    }
}
