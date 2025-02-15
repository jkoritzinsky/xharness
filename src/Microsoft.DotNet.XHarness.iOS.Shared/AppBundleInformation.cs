﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable enable
namespace Microsoft.DotNet.XHarness.iOS.Shared;

public class AppBundleInformation
{
    public string AppName { get; }
    public string BundleIdentifier { get; }
    public string AppPath { get; }
    public string? Variation { get; set; }
    public string LaunchAppPath { get; }
    public bool Supports32Bit { get; }
    public Extension? Extension { get; }
    public string? BundleExecutable { get; }

    public AppBundleInformation(
        string appName,
        string bundleIdentifier,
        string appPath,
        string launchAppPath,
        bool supports32b,
        Extension? extension = null,
        string? bundleExecutable = null)
    {
        AppName = appName;
        BundleIdentifier = bundleIdentifier;
        AppPath = appPath;
        LaunchAppPath = launchAppPath;
        Supports32Bit = supports32b;
        Extension = extension;
        BundleExecutable = bundleExecutable;
    }

    public static AppBundleInformation FromBundleId(string bundleIdentifier) =>
        new(bundleIdentifier, bundleIdentifier, string.Empty, string.Empty, false);
}
