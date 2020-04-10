// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Containerregistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ImportPipelinesOperations.
    /// </summary>
    public static partial class ImportPipelinesOperationsExtensions
    {
            /// <summary>
            /// Gets the properties of the import pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='importPipelineName'>
            /// The name of the import pipeline.
            /// </param>
            public static ImportPipeline Get(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, string importPipelineName)
            {
                return operations.GetAsync(resourceGroupName, registryName, importPipelineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the import pipeline.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='importPipelineName'>
            /// The name of the import pipeline.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportPipeline> GetAsync(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, string importPipelineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, registryName, importPipelineName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an import pipeline for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='importPipelineName'>
            /// The name of the import pipeline.
            /// </param>
            /// <param name='importPipelineCreateParameters'>
            /// The parameters for creating an import pipeline.
            /// </param>
            public static ImportPipeline Create(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, string importPipelineName, ImportPipeline importPipelineCreateParameters)
            {
                return operations.CreateAsync(resourceGroupName, registryName, importPipelineName, importPipelineCreateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an import pipeline for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='importPipelineName'>
            /// The name of the import pipeline.
            /// </param>
            /// <param name='importPipelineCreateParameters'>
            /// The parameters for creating an import pipeline.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportPipeline> CreateAsync(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, string importPipelineName, ImportPipeline importPipelineCreateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, registryName, importPipelineName, importPipelineCreateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an import pipeline from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='importPipelineName'>
            /// The name of the import pipeline.
            /// </param>
            public static void Delete(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, string importPipelineName)
            {
                operations.DeleteAsync(resourceGroupName, registryName, importPipelineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an import pipeline from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='importPipelineName'>
            /// The name of the import pipeline.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, string importPipelineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, registryName, importPipelineName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all import pipelines for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            public static IPage<ImportPipeline> List(this IImportPipelinesOperations operations, string resourceGroupName, string registryName)
            {
                return operations.ListAsync(resourceGroupName, registryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all import pipelines for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ImportPipeline>> ListAsync(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, registryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates an import pipeline for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='importPipelineName'>
            /// The name of the import pipeline.
            /// </param>
            /// <param name='importPipelineCreateParameters'>
            /// The parameters for creating an import pipeline.
            /// </param>
            public static ImportPipeline BeginCreate(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, string importPipelineName, ImportPipeline importPipelineCreateParameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, registryName, importPipelineName, importPipelineCreateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates an import pipeline for a container registry with the specified
            /// parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='importPipelineName'>
            /// The name of the import pipeline.
            /// </param>
            /// <param name='importPipelineCreateParameters'>
            /// The parameters for creating an import pipeline.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ImportPipeline> BeginCreateAsync(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, string importPipelineName, ImportPipeline importPipelineCreateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, registryName, importPipelineName, importPipelineCreateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an import pipeline from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='importPipelineName'>
            /// The name of the import pipeline.
            /// </param>
            public static void BeginDelete(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, string importPipelineName)
            {
                operations.BeginDeleteAsync(resourceGroupName, registryName, importPipelineName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an import pipeline from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='importPipelineName'>
            /// The name of the import pipeline.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IImportPipelinesOperations operations, string resourceGroupName, string registryName, string importPipelineName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, registryName, importPipelineName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists all import pipelines for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ImportPipeline> ListNext(this IImportPipelinesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all import pipelines for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ImportPipeline>> ListNextAsync(this IImportPipelinesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}