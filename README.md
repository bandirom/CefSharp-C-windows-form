


# CefSharp for WinForm C#

### Instruction how to install and setup Chromius browser instead WebBrowser Control in WinForm C#
1. Create new WinForm project

2. Solution - Manage NuGet packages or use NuGet console: "Install-Package CefSharp.WinForms"

3. Browse CefSharp.WinForms and click Install latest stable version
4. When packages will be install

5. Insert in file NameProject.csproj (main folder) next line: 

      `<PropertyGroup>` 
    
       <CefSharpAnyCpuSupport>true</CefSharpAnyCpuSupport>
    
    `</PropertyGroup>`

6. Open app.config and add the folllow lines:

  `<runtime>`
    
    <assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
    
      <probing privatePath="x86"/>
      
    </assemblyBinding>
    
  `</runtime>`
  
