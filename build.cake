#addin nuget:?package=Cake.Git

Task("externals")
    .Does
    (
        () =>
        {
            EnsureDirectoryExists("./externals");
            GitClone
                (
                    "https://github.com/cake-build/cake.git", 
                    "./externals/monodroid-samples", 
                    new GitCloneSettings
                    { 
                    }
                );
        }
    );

RunTarget("externals");

Dictionary<string, string> build_reports_windows= new Dictionary<string, string>()
{
    {
        $"SynchronizedNotifications.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-bcfc59e4441d4352962f20455689cc75.txt"
    },
    {
        $"BasicLocationSample.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-ea602a431767452ead4edc8d041cfddc.txt"
    },	
    {
        $"",
        $""
    },
};

Dictionary<string, string> build_reports_mac= new Dictionary<string, string>()
{
    {
        $"LocUpdFgService.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-37b5057aeec54d3fa3051d1c23855a05.txt"
    },
    {
        $"LocUpdPendIntent.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-13f03e22f4f54c94bf9497d1e9cb8136.txt"
    },
    {
        $"BasicLocationSample.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-8cb216a16968478d97bbf82e5c26c748.txt"
    },
    {
        $"Geofencing.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-225d4a75e728491281da8972c8b48176.txt"
    },
    {
        $"LocationAddress.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-28e606ce40cf4ac3bdcfcb15a2091a31.txt"
    },
    {
        $"LocationUpdates.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-d98c180b164242ebb8072907f61eeaf1.txt"
    },
    {
        $"LocUpdFgService.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-29f9ef891303459581a8fc6c40c0e936.txt"
    },
    {
        $"LocUpdPendIntent.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-d75372b167854f308a4bfd69b97f098c.txt"
    },
    {
        $"BasicLocationSample.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-01a0a9ad199e42758fcf040bba95d54e.txt"
    },
    {
        $"Geofencing.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-0738a81ebbb64ca1b51d8921a212c251.txt"
    },
    {
        $"LocationAddress.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-a49e018081ff47c6b80f5c4681602e05.txt"
    },
    {
        $"LocationUpdates.csproj failed to build.",
        $"http://xqa.blob.core.windows.net/gist/report-e00107a40a7845b8be3e962c2f422866.txt"
    },
    {
        $"",
        $""
    },
};











