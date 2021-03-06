// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Interfaces {

    @@public
    export const dll = BuildXLSdk.library({
        assemblyName: "BuildXL.Cache.MemoizationStore.Interfaces",
        sources: globR(d`.`, "*.cs"),
        references: [
            ContentStore.UtilitiesCore.dll,
            ContentStore.Hashing.dll,
            ContentStore.Interfaces.dll,
            importFrom("BuildXL.Utilities").dll,
            importFrom("BuildXL.Utilities").Collections.dll,
            ...BuildXLSdk.bclAsyncPackages,
        ],
    });
}
