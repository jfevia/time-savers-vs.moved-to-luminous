# Visual Studio Time Savers

Each one of this extension's features can be accessed via one or more of the following methods:
- the *Time Savers* toolbar
- the *Time Savers* main menu
- the *Time Savers* context menu
- a keyboard shortcut (if the feature has one)

Some shortcut key combinations may have already been in use by Visual Studio
(in these cases I've tried to only use ones that have less chance of people needing them)

Most of the features are available via all of the methods,
whereas as others may only be available via some of them.

>Please Note: the missing images will be added soon!

## Features

- Activity Log
- Cancel Build
- Close Solution
- Diagnostics Log
- Edit Project
- Edit Solution
- Extensions and Updates
- Insert Guid(s)
- Keyboard Options
- Path Variables
- Rebuild Project
- Rebuild Solution
- Reopen Start Page
- Restart Visual Studio
- Restart Visual Studio as Admin
- Time Savers Options

---

#### Activity Log Feature

Opens the Visual Studio Activity Log that records actions/errors from any installed extensions.

>The file's path is *%APPDATA%\Microsoft\VisualStudio\version\ActivityLog.xml*
>
>- *%APPDATA%* represents the value in the APPDATA environment variable
>- *version* represents the current Visual Studio version (ie 14.0 2015)

##### Without This Extension Installed

- open a *File Explorer* window
- navigate to *%AppData%\Roaming\Microsoft\VisualStudio\14.0*
- locate ActivityLog.xml
- open the file in a text editor

##### With This Extension Installed

- **Time Savers Toolbar**
    - click the *Developer Commands* dropdown on the toolbar
    - click on *Activity Log*
    - ![Activity Log (toolbar)][activity-log-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu
    - select *Activity Log*
    - ![Activity Log (menu)][activity-log-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Activity Log*
    - ![Activity Log (context)][activity-log-context]

The log is opened in a Visual Studio browser window.

---

#### Cancel Build Feature

A convenient way to cancel a running build/rebuild.

##### Without This Extension Installed

- move your mouse up to the *Build* menu
- click it
- select *Cancel*

##### With This Extension Installed

This feature is only enabled if a build/rebuild **is** currently in progress.

- **Time Savers Toolbar**
    - click the *Cancel Build* button on the *Time Savers* toolbar
    - ![Cancel Build (toolbar)][cancel-build-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu in *Visual Studio*'s main menu bar
    - select *Rebuild Project*
    - ![Cancel Build (menu)][cancel-build-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Cancel Build*
    - ![Cancel Build (context)][cancel-build-context]
- **Keyboard Shortcut**
    - Ctrl-Alt-X

Once the build/rebuild has been cancelled:
- the *Rebuild Project* and *Rebuild Solution* buttons are **enabled**
- the *Cancel Build* button is **disabled**

---

#### Close Solution Feature

Close the current solution.

##### Without This Extension Installed

- move your mouse up to the *Solution* node
- click it
- move your mouse up to the *File* menu
- select *Close Solution*

##### With This Extension Installed

- **Solution Node**
    - right-click on the *Solution Name* node
    - select *Close Solution*
    - ![Close Solution (solution node)][close-solution-node]
- **Time Savers Menu**
    - click on the *Time Savers* menu
    - select *Close Solution*
    - ![Close Solution (menu)][close-solution-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Close Solution*
    - ![Close Solution (context)][close-solution-context]

---

#### Diagnostic Log Feature

Opens the most recent MSBuild diagnostic log file.

>The file is: *%LOCALAPPDATA%\Temp\MSBuild_guid.failure.txt*
>
>- *%LOCALAPPDATA%* represents the value in the *LOCALAPPDATA* environment variable
>- *guid* represents a random guid value

##### Without This Extension Installed

- open a *File Explorer* window
- navigate to *%LOCALAPPDATA%\Temp*
- locate the latest MSBUILD_*.xml file
- open the file in a text editor

##### With This Extension Installed

- **Time Savers Toolbar**
    - click the *Developer Commands* dropdown on the toolbar
    - click on *Diagnostic Log*
    - ![Diagnostic Log (toolbar)][diagnostic-log-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu
    - select *Diagnostic Log*
    - ![Diagnostic Log (menu)][diagnostic-log-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Diagnostic Log*
    - ![Diagnostic Log (context)][diagnostic-log-context]

The log is opened in a Visual Studio browser window.

---

#### Edit Project Feature

Open a project's *csproj* file in an xml editor.

##### Without This Extension Installed

- move your mouse up to the *Project* node
- click it
- move your mouse up to the *Project* menu
- select *Unload Project*
- move cursor back to the *Project* mode
- right-click it
- select *Edit [ProjectName].csproj*

##### With This Extension Installed

- **Project Node**
    - right-click on the *Project* node
    - click on *Edit Project*
    - ![Edit Project (project node)][edit-project-node]
- **Time Savers Menu**
    - click on the *Time Savers* menu
    - select *Edit Project*
    - ![Edit Project (menu)][edit-project-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Edit Project*
    - ![Edit Project (context)][edit-project-context]

The project file opens in an XML window, ready for editing.

---

#### Edit Solution Feature

Open a solution's *.sln* file in an xml editor.

##### Without This Extension Installed

- move your mouse up to the *Solution* node
- click it
- move your mouse up to the *File* menu
- select *Close Solution*
- (explorer window)
- (text editor)
- (reopen solution)

##### With This Extension Installed

- **Solution Node**
    - right-click on the *Solution Name* node
    - click on *Edit Solution*
    - ![Edit Solution (solution node)][edit-solution-node]
- **Time Savers Menu**
    - click on the *Time Savers* menu
    - select *Edit Solution*
    - ![Edit Solution (menu)][edit-solution-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* from the context menu
    - select *Edit Solution*
    - ![Edit Solution (context)][edit-solution-context]

The solution file opens in an XML window.

---

#### Extensions and Updates Feature

A easy way to open the *Extensions and Updates* dialog.

This one's about pure personal convenience.
I often find myself needing to open dialog this multiple times a day
(installing or uninstalling extension(s), looking up versions etc).

I've lost count of how many times I've **accidentally** ended up clicking on *Options*
instead of *Extensions and Updates*.
Or found myself looking up and down the menu trying to find it in the *Tools* menu.

##### Without This Extension Installed

- move your mouse up to the *Tools* menu
- click it
- find and select *Extensions and Options*

##### With This Extension Installed

- **Time Savers Toolbar**
    - click the *Extensions and Updates* button on the *Time Savers* toolbar
    - ![Extensions and Updates][extensions-updates-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu in *Visual Studio*'s main menu bar
    - select *Rebuild Project*
    - ![Extensions and Updates (menu)][extensions-updates-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Extensions and Updates*
    - ![Extensions and Updates][extensions-updates-context]

---

#### Insert Guid(s) Feature 

Insert a single guid, or multiple guids directly into your code without the use of any **external** tool.

- insert **a single guid**, by simply moving the cursor to where you want to insert it and invoke the command
- insert **multiple unique guids** at the same time by making a multi-line selection before invoking the command
- replace **some existing text** with a guid by selecting it then invoke the command
- replace **multiple lines of text** by making a multi-line selection before invoking the command

##### Without This Extension Installed

- move your mouse up to the *Tools* menu
- select *Create GUID*
- click the *Copy* button, or the *New GUID* button
- move your cursor to where you want the guid
- right-click and select *Paste*
- (repeat these steps for multiple guids)

##### With This Extension Installed

- **Time Savers Menu**
    - click on the *Time Savers* menu in *Visual Studio*'s main menu bar
    - select *Insert Guid*
    - ![Insert Guid (menu)][insert-guid-menu]
- **Context Menu**
    - in the code file where you want the guid(s)
      - move the cursor to the desired location
      - **or** make a muliple-line insertion
      - **or** select some text that you want to replace
      - **or** make a muliple-line selection of text to replace
    - right click
    - select *Time Savers*
    - select *Insert Guid(s)*
    - ![Insert Guid (context)][insert-guid-context]
- **Shortcut**
    - *Ctrl-Alt-I*, *Ctrl-Alt-G*

---

#### Keyboard Options Feature

Open the *Tools* | *Options* dialog at the *Environment* | *Keyboard* node.
This is really handy when you're trying to set up keyboard shortcuts.

##### Without This Extension Installed

- move your mouse up to the *Tools* menu
- click it
- select *Options*
- find and expand the *Environment* node
- select *Keyboard*

##### With This Extension Installed

- **Time Savers Toolbar**
    - click the *Keyboard Options* dropdown on the toolbar
    - ![Keyboard Options (toolbar)][keyboard-options-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu
    - select *Keyboard Options*
    - ![Keyboard Options (menu)][keyboard-options-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Keyboard Options*
    - ![Keyboard Options (context)][keyboard-options-context]

The *Options* dialog opens with the *Keyboard* node selected.

---

#### Path Variables Feature

Displays the current set of Windows paths variable values.

##### Without This Extension Installed

- open a *cmd* window
- type *path*
- press ENTER

##### With This Extension Installed

- **Time Savers Toolbar**
    - click the *Developer Commands* dropdown on the toolbar
    - click on *Path Variables*
    - ![Path Variables (toolbar)][path-variables-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu
    - select *Path Variables*
    - ![Path Variables (menu)][path-variables-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Path Variables*
    - ![Path Variables (context)][path-variables-context]

The path variables are displayed in the *Output* window.

---

#### Rebuild Project Feature

A convenient way to rebuild the just the current project
(either a selected project, or the project to which the active code document belongs).

##### Without This Extension Installed

- move your mouse to a project node in *Solution Explorer*
- right-click it
- select *Rebuild Project*
**or**
- move your mouse to a project node in *Solution Explorer*
- click it
- move your mouse up to the *Build* menu
- click it
- select *Rebuild Project*

##### With This Extension Installed

This feature is only enabled if a build/rebuild is **not** currently in progress.

- **Time Savers Toolbar**
    - click the *Rebuild Project* button on the *Time Savers* toolbar
    - ![Rebuild Project (toolbar)][rebuild-project-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu in *Visual Studio*'s main menu bar
    - select *Rebuild Project*
    - ![Rebuild Project (menu)][rebuild-project-menu]
- **Context Menu**
    - right-click in any code window
    - click on *Time Savers* in the context menu
    - click on *Rebuild Project*
    - ![Rebuild Project (context)][rebuild-project-context]
- **Shortcut**
    - *Ctrl-Alt-9*

Once Visual Studio starts rebuilding the current project:
- the *Rebuild Solution* and *Rebuild Project* buttons are **disabled**
- the *Cancel Build* button is **enabled**

---

#### Rebuild Solution Feature

A convenient way to rebuild the whole solution.

##### Without This Extension Installed

- move your mouse to the solution node in *Solution Explorer*
- right-click it
- select *Rebuild Solution*
**or**
- move your mouse up to the *Build* menu
- click it
- select *Rebuild Solution*

##### With This Extension Installed

This feature is only enabled if a build/rebuild is **not** currently in progress.

- **Time Savers Toolbar**
    - click the *Rebuild Solution* button on the *Time Savers* toolbar
    - ![Rebuild Solution (toolbar)][rebuild-solution-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu in *Visual Studio*'s main menu bar
    - select *Rebuild Solution*
    - ![Rebuild Solution (menu)][rebuild-solution-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Rebuild Solution*
    - ![Rebuild Solution (context)][rebuild-solution-context]
- **Shortcut**
    - *Ctrl-Alt-0*

Once Visual Studio starts rebuilding the solution:
- the *Rebuild Solution* and *Rebuild Project* buttons are **disabled**
- the *Cancel Build* button is **enabled**

---

#### Reopen Start Page

Automatically reopen the *Start Page* when the solution is closed.

#### Restart Visual Studio Feature

Unlock Visual Studio's built-in ability to restart itself.

Have you ever wished there was an **easy** way to restart Visual Studio,
just like the *Extensions and Updates* dialog does
after installing/uninstalling an extension, and ending up back in the same project that you were working on?

##### Without This Extension Installed

- close *Visual Studio*
- reopen *Visual Studio*
- wait for Visual Studio to load
- move your cursor to the *File Menu*
- click it
- select *Recent Projects and Solutions*
- select the project that you were working on before the restart

##### With This Extension Installed

- **Time Savers Toolbar**
    - click the *Restart Visual Studio* button on the toolbar
    - ![Restart Visual Studio (toolbar)][restart-vs-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu in *Visual Studio*'s main menu bar
    - select *Restart Visual Studio*
    - ![Restart Visual Studio (menu)][restart-vs-menu]
- **Context Menu**
    - right-click in any code window
    - click on *Time Savers* in the context menu
    - click on *Cancel Build*
    - ![Restart Visual Studio (context)][restart-vs-context]

Visual Studio restarts and automatically re-opens the project that you were working on.

---

#### Restart Visual Studio as Admin Feature

Restart Visual Studio as administrator (elevated session).

##### Without This Extension Installed

- close *Visual Studio*
- right-click *Visual Studio* (on the Start menu, or on the Taskbar etc)
- select *Run as administrator*
- accept the User Control prompt
- wait for Visual Studio to load
- move your cursor to the *File Menu*
- click it
- select *Recent Projects and Solutions*
- select the project that you were working on before the restart

##### With This Extension Installed

- **Time Savers Toolbar**
    - click the *Restart* dropdown on the toolbar
    - select *Restart Visual Studio as Administrator*
    - ![Restart Visual Studio as Administrator (toolbar)][restart-vs-admin-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu
    - select *Restart Visual Studio as Administrator*
    - ![Restart Visual Studio as Administrator (menu)][restart-vs-admin-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Restart Visual Studio as Administrator*
    - ![Restart Visual Studio as Administrator (context)][restart-vs-admin-context]

Visual Studio restarts an elevated session
and automatically re-opens the project that you were working on.

---

#### Time Savers Options Feature

Open the *Tools* | *Options* dialog at the *Time Savers* node.

##### Without This Extension Installed

- move your mouse up to the *Tools* menu
- click it
- select *Options*
- find and expand the *Time Savers* node

##### With This Extension Installed

- **Time Savers Toolbar**
    - click the *Time Savers Options* button on the toolbar
    - ![Time Savers Options (toolbar)][time-savers-options-toolbar]
- **Time Savers Menu**
    - click on the *Time Savers* menu
    - select *Time Savers Options*
    - ![Time Savers Options (menu)][time-savers-options-menu]
- **Context Menu**
    - right-click in any code window
    - select *Time Savers* in the context menu
    - select *Time Savers Options*
    - ![Time Savers Options (context)][time-savers-options-context]

The *Options* dialog opens with the *Time Savers* node selected.

---

<div style="text-align:center">
    <img src="../art/lss-vsip.png" />
</div>

[activity-log-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/activity-log-toolbar.png
[activity-log-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/activity-log-menu.png
[activity-log-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/activity-log-context.png

[cancel-build-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/cancel-build-toolbar.png
[cancel-build-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/cancel-build-menu.png
[cancel-build-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/cancel-build-context.png

[close-solution-node]: https://github.com/yannduran/time-savers-vs/raw/master/art/close-solution-node.png
[close-solution-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/close-solution-menu.png
[close-solution-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/close-solution-context.png

[diagnostic-log-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/diagnostic-log-toolbar.png
[diagnostic-log-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/diagnostic-log-menu.png
[diagnostic-log-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/diagnostic-log-context.png

[edit-project-node]: https://github.com/yannduran/time-savers-vs/raw/master/art/edit-project-node.png
[edit-project-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/edit-project-menu.png
[edit-project-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/edit-project-context.png

[edit-solution-node]: https://github.com/yannduran/time-savers-vs/raw/master/art/edit-solution-node.png
[edit-solution-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/edit-solution-menu.png
[edit-solution-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/edit-solution-context.png

[extensions-updates-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/extensions-toolbar.png
[extensions-updates-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/extensions-menu.png
[extensions-updates-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/extensions-context.png

[insert-guid-menu]: https://github.com/yannduran/timeSavers-vs/raw/master/art/insert-guid-menu.png
[insert-guid-menu]: https://github.com/yannduran/timeSavers-vs/raw/master/art/insert-guid-menu.png
[insert-guid-context]: https://github.com/yannduran/timeSavers-vs/raw/master/art/insert-guid-context.png

[keyboard-options-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/keyboard-options-toolbar.png
[keyboard-options-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/keyboard-options-menu.png
[keyboard-options-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/keyboard-options-context.png

[path-variables-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/path-variables-toolbar.png
[path-variables-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/path-variables-menu.png
[path-variables-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/path-variables-context.png

[rebuild-project-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/rebuild-project-toolbar.png
[rebuild-project-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/rebuild-project-menu.png
[rebuild-project-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/rebuild-project-context.png

[rebuild-solution-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/rebuild-solution-toolbar.png
[rebuild-solution-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/rebuild-solution-menu.png
[rebuild-solution-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/rebuild-solution-context.png

[reopen-vs-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/reopen-vs-toolbar.png
[reopen-vs-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/reopen-vs-menu.png
[reopen-vs-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/reopen-vs-context.png

[restart-vs-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/restart-vs-toolbar.png
[restart-vs-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/restart-vs-menu.png
[restart-vs-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/restart-vs-context.png

[restart-vs-admin-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/restart-vs-admin-toolbar.png
[restart-vs-admin-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/restart-vs-admin-menu.png
[restart-vs-admin-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/restart-vs-admin-context.png

[separators]: https://github.com/yannduran/time-savers-vs/raw/master/art/separators.png

[separators-options-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/separators-options-toolbar.png
[separators-options-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/separators-options-menu.png
[separators-options-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/separators-options-context.png

[time-savers-options-toolbar]: https://github.com/yannduran/time-savers-vs/raw/master/art/time-savers-options-toolbar.png
[time-savers-options-menu]: https://github.com/yannduran/time-savers-vs/raw/master/art/time-savers-options-menu.png
[time-savers-options-context]: https://github.com/yannduran/time-savers-vs/raw/master/art/time-savers-options-context.png
