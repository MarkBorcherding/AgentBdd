# ReSharper BDD Live Template Macros
I wanted to create a live template with a macro like the following:

    [Then(@"$step$")]
    public void function Then_$step_name_function$(){
    }

Unfortunately, there was no way to create a method name from another variable. Creating 
macros turns out to be pretty easy.

# Installation
Simply run `rake deploy` from the command line...after installing `rake` ofcourse.

Import the live templates.

# Usage

Type `given` and press `<Tab>` and you should see the template expand and update
while you type the step.

# Todo

1. account for `(.*)` and `(\d+)` in the step and add arguments to the function
1. offer the `Function_name_with_underscore` and also `FunctionNameWithProperCase` option


