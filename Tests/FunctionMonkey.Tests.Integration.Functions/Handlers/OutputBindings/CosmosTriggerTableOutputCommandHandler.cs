﻿using System.Threading.Tasks;
using AzureFromTheTrenches.Commanding.Abstractions;
using FunctionMonkey.Tests.Integration.Functions.Commands.OutputBindings;
using FunctionMonkey.Tests.Integration.Functions.Model;

namespace FunctionMonkey.Tests.Integration.Functions.Handlers.OutputBindings
{
    class CosmosTriggerTableOutputCommandHandler : ICommandHandler<CosmosTriggerTableOutputCommand, MarkerTableEntity>
    {
        public Task<MarkerTableEntity> ExecuteAsync(CosmosTriggerTableOutputCommand command, MarkerTableEntity previousResult)
        {
            return MarkerTableEntity.Success(command.MarkerId);
        }
    }
}
