# NetMsixUpdaterFormsComponent
### A component for Windows Forms using NetMsixUpdater to implement updates to Forms apps more fast.

![downloads](https://img.shields.io/nuget/dt/NetMsixUpdaterFormsComponent)
![version](https://img.shields.io/nuget/v/NetMsixUpdaterFormsComponent)

## Dependencies
- net5.0-windows7.0
- Microsoft.Web.WebView2 (>= 1.0.1054.31)
- NetMsixUpdater (>= 0.2.2)

## Instalation
### PM
```powershell
Install-Package NetMsixUpdaterFormsComponent
```
### .NET CLI
```powershell
dotnet add package NetMsixUpdaterFormsComponent
```

## Example
```csharp
public partial class Form1 : Form
{
    private UpdateForm updateForm { get; }

    public Form1()
    {
        InitializeComponent();

        updateForm = new(new(Assembly.GetExecutingAssembly(), Consts.YAML_UPDATE_PATH));
    }

    private void Form1_Load(object sender, EventArgs e)
    { 
        lblAssemblyVersion.Text = string.Format(lblAssemblyVersion.Text, 
            Assembly.GetExecutingAssembly().GetName().Version);
        lblUpdated.Text = string.Format(lblUpdated.Text, updateForm.msixUpdater.hasUpdated.ToString());
    }

    private void btnSearchUpdate_Click(object sender, EventArgs e) => updateForm.Start();
}
```
> Setup and initialize `UpdateForm`

## Documentation
Documentation is available on [Wiki](https://github.com/LuanRoger/NetMsixUpdaterFormsComponent/wiki)
