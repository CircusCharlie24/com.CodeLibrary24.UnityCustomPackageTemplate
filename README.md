# Unity Custom Package Template

A template for making custom unity packages.

# Adding dependencies

 "dependencies": {
     "com.codelibrary24.dummydependency": "1.0.0",
     "com.codelibrary24.dummydependency": "1.0.1"
 },


 # Adding Samples

 1. Create a folders called Sample~/SampleFolder_01
 2. Add the following in the package.json file:-
     "samples": [
     {
            "displayName": "Dummy Sample 01",
            "description": "This is a Dummy description",
            "path": "Samples~/SampleFolder_01"
        }
    ],
 4. Samples~ is not shown inside unity as long as the '~' is part of the name, hence when you want to edit the samples, remove the '~' and add it back when you are done and ready to publish the package.
    

