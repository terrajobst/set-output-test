var pullRequestNumber = 42;
var pullRequestIsClosed = true;
var pullRequestIsMerged = true;

var githubOutputPath = Environment.GetEnvironmentVariable("GITHUB_OUTPUT");
if (!string.IsNullOrEmpty(githubOutputPath))
{
    File.AppendAllLines(
        githubOutputPath,
        new[]{
            $"pull_request_number={pullRequestNumber}",
            $"pull_request_is_closed={pullRequestIsClosed.ToString().ToLower()}",
            $"pull_request_is_merged={pullRequestIsMerged.ToString().ToLower()}"
        }
    );
}

// Console.WriteLine($"::set-output name=pull_request_number::{pullRequestNumber}");
// Console.WriteLine($"::set-output name=pull_request_is_closed::{pullRequestIsClosed.ToString().ToLower()}");
// Console.WriteLine($"::set-output name=pull_request_is_merged::{pullRequestIsMerged.ToString().ToLower()}");
