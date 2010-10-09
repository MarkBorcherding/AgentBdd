# ReSharper BDD Live Template Macros
I wanted to create a live template with a macro like the following:

    [Then(@"$step$")]
    public void function Then_$step_name_function$(){
    }

Unfortunately, there was no way to create a method name from another variable. Creating Îmacros turns out to be pretty easy.

## Installation
Simply run `rake deploy` from the command line...after installing `rake` ofcourse.

Import the live templates.

## Usage

Type `given` and press `<Tab>` and you should see the template expand and update
while you type the step.

## Todo

1. account for `(.*)` and `(\d+)` in the step and add arguments to the function
1. offer the `Function_name_with_underscore` and also `FunctionNameWithProperCase` option

# Growl Unit

I've been using the NUnit GUI to run my specs. What I like about the NUnit GUI is it has a setting to rerun the last set of tests after they are rebuilt. It works similar to Autotest. What was missing was a growl display when the tests fail or pass.

There is another project that I found that already does this, but for some reason, it wasn't working for me. After looking into it, it was pretty easy to write a plugin so I started another one file assembly.

This should probably move outside of the AgentBDD project, but they are closely related in my mind, and both are so tiny, I'll keep them together for now.

