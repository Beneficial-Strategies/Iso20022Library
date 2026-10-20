// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Mechanically guards against a real, previously-shipped defect: a version bump to
/// <c>src/Directory.Build.props</c> leaving stale <c>dotnet add package ... --version</c> pins
/// behind in one or more package READMEs. This happened repeatedly before this test existed —
/// most visibly, this repo shipped two divergent copies of the Common package's own README for
/// several releases (<c>README.md</c> at the repo root, and a separately-packed
/// <c>doc/package/README.md</c> that drifted out of sync and even lacked a version pin
/// entirely) — see the README restructuring around 2026-08-31 that collapsed this to one
/// <c>README.md</c> per published project, living in that project's own root.
/// </summary>
/// <remarks>
/// This is independent of whether <c>.claude/skills/bump-and-release/SKILL.md</c> was actually
/// invoked correctly for a given release — it re-derives the expected version straight from
/// <c>Directory.Build.props</c> (the single shared source of truth per <c>CLAUDE.md</c>'s
/// "Multi-Package Repository Strategy") and cross-checks every package README's own install
/// instructions against it, regardless of how or whether the bump happened.
/// </remarks>
public class ReadmeVersionPinTests
{
    /// <summary>
    /// Matches lines like <c>dotnet add package BeneficialStrategies.Iso20022.FluentValidation
    /// --version 0.6.2-alpha</c>. Deliberately scoped to only this repo's own
    /// <c>BeneficialStrategies.Iso20022*</c> package family — a README may legitimately pin an
    /// unrelated third-party package (e.g. <c>Microsoft.Extensions.DependencyInjection</c>) to a
    /// version that has nothing to do with this repo's own release cadence, and that must not be
    /// flagged as drift.
    /// </summary>
    private static readonly Regex PackagePinPattern = new(
        @"dotnet add package (BeneficialStrategies\.Iso20022(?:\.\S+)?) --version (\S+)",
        RegexOptions.Compiled
    );

    /// <summary>
    /// Walks up from the test assembly's own output directory to the repository root. Confirmed
    /// depth for both TFMs: <c>bin/Debug/{net8.0|net10.0}/</c> → project dir → <c>src</c> → repo
    /// root is 5 levels, since <see cref="AppContext.BaseDirectory"/> already points at the TFM
    /// folder itself.
    /// </summary>
    private static string FindRepoRoot()
    {
        var dir = new DirectoryInfo(AppContext.BaseDirectory);
        for (var i = 0; i < 5 && dir.Parent is not null; i++)
            dir = dir.Parent;
        return dir.FullName;
    }

    [Fact]
    public void AllPackageReadmeVersionPins_MatchDirectoryBuildProps()
    {
        var repoRoot = FindRepoRoot();

        var propsPath = Path.Combine(repoRoot, "src", "Directory.Build.props");
        Assert.True(File.Exists(propsPath), $"Expected to find {propsPath} — repo-root resolution may be wrong.");

        var propsText = File.ReadAllText(propsPath);
        var versionMatch = Regex.Match(propsText, @"<Version>([^<]+)</Version>");
        Assert.True(
            versionMatch.Success,
            $"Could not find a <Version> element in {propsPath} - this test can't verify anything without it."
        );
        var expectedVersion = versionMatch.Groups[1].Value;

        // Every project directory under src/ that packs its own README as the NuGet page —
        // i.e. every project whose .csproj declares <PackageReadmeFile>. This auto-discovers new
        // packages (e.g. once MassTransit.Sagas is actually published) with no test code change.
        var srcDir = Path.Combine(repoRoot, "src");
        var readmePaths = Directory
            .GetDirectories(srcDir)
            .Where(projectDir =>
                Directory
                    .GetFiles(projectDir, "*.csproj")
                    .Any(csproj => File.ReadAllText(csproj).Contains("<PackageReadmeFile>"))
            )
            .Select(projectDir => Path.Combine(projectDir, "README.md"))
            .Where(File.Exists)
            .ToList();

        Assert.True(
            readmePaths.Count >= 2,
            $"Expected at least 2 packable projects with their own README.md under {srcDir}, found "
                + $"{readmePaths.Count}. Either packages were removed, or <PackageReadmeFile>/README.md "
                + "placement changed and this test's discovery logic no longer finds them."
        );

        var totalMatches = 0;
        foreach (var readmePath in readmePaths)
        {
            var lineNumber = 0;
            foreach (var line in File.ReadLines(readmePath))
            {
                lineNumber++;
                var match = PackagePinPattern.Match(line);
                if (!match.Success)
                    continue;

                totalMatches++;
                var packageId = match.Groups[1].Value;
                var pinnedVersion = match.Groups[2].Value;
                Assert.True(
                    pinnedVersion == expectedVersion,
                    $"{readmePath}:{lineNumber} pins {packageId} to --version {pinnedVersion}, but "
                        + $"src/Directory.Build.props currently has <Version>{expectedVersion}</Version>. "
                        + "Update this README line to match (or, if this is a genuinely older/pinned "
                        + "example, exclude it from this check's pattern instead of leaving it silently wrong)."
                );
            }
        }

        // Guards against the pattern itself silently matching nothing (e.g. after a README
        // rewrite changes the install command's wording) and this test passing vacuously.
        Assert.True(
            totalMatches >= 2,
            $"Expected at least 2 'dotnet add package BeneficialStrategies.Iso20022...' install "
                + $"lines across {readmePaths.Count} README file(s), found {totalMatches}. Either the "
                + "READMEs lost their install instructions, or this test's regex no longer matches "
                + "their current wording — either way, this test isn't actually checking anything "
                + "right now and needs attention."
        );
    }
}
