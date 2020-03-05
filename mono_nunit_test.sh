#!/usr/bin/env bash

wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mozroots --import --sync

echo "[INFO] remove bin/Debug/ApihubClientTest.dll"
rm src/IO.EflowPeru.Test/bin/Debug/IO.EflowPeru.Test.dll 2> /dev/null

echo "[INFO] install NUnit runners via NuGet"
wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mozroots --import --sync
mono nuget.exe install src/IO.EflowPeru.Test/packages.config -o packages

echo "[INFO] Install NUnit runners via NuGet"
mono nuget.exe install NUnit.Runners -Version 2.6.4 -OutputDirectory packages

echo "[INFO] Build the solution and run the unit test"
msbuild IO.EflowPeru.sln && \
    mono ./packages/NUnit.Runners.2.6.4/tools/nunit-console.exe src/IO.EflowPeru.Test/bin/Debug/IO.EflowPeru.Test.dll
