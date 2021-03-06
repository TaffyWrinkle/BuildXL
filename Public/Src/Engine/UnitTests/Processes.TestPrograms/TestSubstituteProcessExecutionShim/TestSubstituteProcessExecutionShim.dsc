// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

import * as Managed from "Sdk.Managed";
import * as Deployment from "Sdk.Deployment";

namespace TestSubstituteProcessExecutionShim {
    // This has to remain in net472 because buildxl.processes test uses this
    // and it doesn't deploy it to a subfolder, so since that test has to run in
    // net472 it would collide with nuget dependencies.
    export declare const qualifier : BuildXLSdk.DefaultQualifierWithNet472;
    @@public
    export const exe = BuildXLSdk.executable({
        assemblyName: "TestSubstituteProcessExecutionShim",
        skipDocumentationGeneration: true,
        sources: [f`TestSubstituteProcessExecutionShimProgram.cs`],
    });
}
