# Game Source

The source folder will keep the game's source code. You will need to save/create your game project in this folder.

## Game Engine / Framework

Depending on your game engine or framework, you will need to use the appropriate configuration files in your project.

### Unity

Create your Unity game inside this source folder.

1. Move the `Unity.editorconfig`, `Unity.gitignore` and `Unity.gitattributes` files inside your Unity project.
2. Rename the files by removing **Unity** from the file name.
3. Delete all the other unrelated configuration files.

### Unreal Engine

Create your Unreal Engine game inside this source folder.

1. Move the `UnrealEngine.editorconfig`, `UnrealEngine.gitignore` and `UnrealEngine.gitattributes` files inside your Unreal Engine project.
2. Rename the files by removing **UnrealEngine** from the file name.
3. Delete all the other unrelated configuration files.

### Construct 2 + 3

Create your Construct project inside this source folder.  
Construct projects should be saved as a folder project and not as a single file, this will help you to better source control the project source files.

1. Move the `Construct[2/3].gitignore` and `Construct[2/3].gitattributes` files inside your Construct 2/3 project.
2. Rename the files by removing **Default** from the editorconfig and **Construc[2/3]** from the git configuration files.
3. Delete all the other unrelated configuration files.

### GameMaker Studio Classic 1.4

Create your GameMaker project inside this source folder.  

1. Move the `GM1.gitattributes` files inside your GameMaker project.
2. Rename the files by removing **GM1** from the git configuration files.
3. Delete all the other unrelated configuration files.

### GameMaker Studio 2

Create your GameMaker project inside this source folder.

[Getting json to merge correctly for GMS 2](https://forum.yoyogames.com/index.php?threads/issues-when-using-git-or-svn-with-gms2.23848/post-230902)

1. Install [git-json-merge](https://github.com/jonatanpedersen/git-json-merge) -- Node and npm required for this.
2. Move the `GM2.gitconfig` and `GM2.gitattributes` files inside your GameMaker project.
3. Rename the files by removing **GM2** from the git configuration files.
4. Delete all the other unrelated configuration files.

### Stencyl

Create your Stencyl project inside this source folder.  

1. Move the `Stencyl.gitignore` and `Stencyl.gitattributes` files inside your Stencyl project.
2. Rename the files by removing **Stencyl** from the git configuration files.
3. Delete all the other unrelated configuration files.

## Source Folder Structure

The source folder should look something like this:

```folders
.
└─── source/
  └── <Game-Project-Name>/
    ├── .editorconfig
    ├── .gitattributes
    └── .gitignore
```
