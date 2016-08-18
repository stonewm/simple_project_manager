# DockPanel Test

This project test DockPanel, which will be used as the UI framework.

## 添加dll的引用

Add reference -> WeifenLuo.WinFormUI.Docking.dll

## 创建Mainform，并且作为启动form

属性设置：
- IsMDIContainer = true
- WindowState = Maximized

## 在MainForm上加载DocPanel

将DocPanel加载到MainForm。Toolbox，右键，choose items，然后通过Browse按钮，找到dll，
即可加载到toolbox

DocPanel属性：

- Dock: Fill

## 定义navigation form

navigation form放在主界面的左边。这个form继承自DockContent

## 定义DocForm

DocForm继承自DockContent
DocForm中放置richTextBox，模拟编辑器。

## 其他看MainForm的代码





