﻿using System;
using Matrix.Client.Requests;

namespace Matrix.Client.Tests.SysInteg.Common
{
    public class TestsFixture : IDisposable
    {
        public readonly IMatrixClient MatrixClient = new MatrixClient { ShouldValidateRequests = true };

        public TestsFixture()
        {
            var req = new LoginRequest(
                ConfigurationProvider.TestConfigurations.UserName,
                ConfigurationProvider.TestConfigurations.Password
            );

            MatrixClient.AccessToken = MatrixClient.LoginAsync(req).Result.AccessToken;
        }

        public void Dispose()
        {

        }
    }
}
