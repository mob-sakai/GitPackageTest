Demo: Git Dependency Resolver For Unity
===

This demo project has the following dependency graph.

`com.coffee.package-a` has a git urls as dependency for `com.coffee.core-a`.

```
project
  -> com.coffee.package-a@https://github.com/mob-sakai/GitPackageTest#package-a-0.1.0
    -> com.coffee.core-a@https://github.com/mob-sakai/GitPackageTest#core-a-0.1.0
```



<br><br><br><br>
## Demo

1. Open this project with Unity 2018.3 or later.
2. When `Unity Package Manager Error` window is opens, click `Continue`.  
![window](https://user-images.githubusercontent.com/12690315/57823865-08726e80-77d4-11e9-8203-46bf22d504d9.png)
3. An error is displayed in console view and the project is not working.  
![console](https://user-images.githubusercontent.com/12690315/57829436-e84daa00-77e9-11e9-84af-f5e46b1f0f02.png)
4. Close the project and edit `Packages/manifest.json` to look like this:
```js
{
  "dependencies": {
    "com.coffee.git-dependency-resolver": "https://github.com/mob-sakai/GitDependencyResolverForUnity.git#1.0.0",
    ...
  },
}
```
5. Reopen the project.
6. The dependency is resolved successfully! :)  
![success](https://user-images.githubusercontent.com/12690315/57830788-2e0c7180-77ee-11e9-9228-50bf5976c876.png)



<br><br><br><br>
## Note

1. If dependencies are not resolved successfully, try the following:
    * Delete `Library` directory in the project.  
![library](https://user-images.githubusercontent.com/12690315/57830868-690ea500-77ee-11e9-9e47-4a9794d77da8.png)
    * Reopen the project.



<br><br><br><br>
## See Also

* GitHub page : https://github.com/mob-sakai/GitDependencyResolverForUnity
