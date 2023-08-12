using osu.Game.Updater;
using osu.Framework.Allocation;
using System;

namespace osu.Game.Rulesets.Sentakki;

public partial class SentakkiUpdateManager : SimpleUpdateManager
{
    protected override string GitHubUrl => "https://api.github.com/repos/LumpBloom7/sentakki/releases/latest";

    protected override string UpdatedComponentName => "sentakki";

    [BackgroundDependencyLoader]
    private void load()
    {
        var assemblyVersion = typeof(SentakkiUpdateManager).Assembly?.GetName().Version ?? new Version();

        Version = $@"{assemblyVersion.Major}.{assemblyVersion.Minor}.{assemblyVersion.Build}";
    }
}
