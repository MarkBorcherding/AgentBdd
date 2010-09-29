# ReSharper BDD Live Template Macros
I wanted to create a live template with a macro like the following:

    [Then(@"$step$")]
    public void function $step_name_function$(){
    }

Unfortunately, there was no way to create a method name from another variable. Creating 
macros turns out to be pretty easy.

# Todo

I want to do the following:

1. clean up the way the method name is created
2. bundle the live templates
3. offer the `Function_name_with_underscore` and also `FunctionNameWithProperCase` option


