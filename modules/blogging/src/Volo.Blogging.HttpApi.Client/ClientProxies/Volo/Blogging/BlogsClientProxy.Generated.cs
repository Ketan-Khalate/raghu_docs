// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using Volo.Blogging.Blogs;
using Volo.Blogging.Blogs.Dtos;

// ReSharper disable once CheckNamespace
namespace Volo.Blogging;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IBlogAppService), typeof(BlogsClientProxy))]
public partial class BlogsClientProxy : ClientProxyBase<IBlogAppService>, IBlogAppService
{
    public virtual async Task<ListResultDto<BlogDto>> GetListAsync()
    {
        return await RequestAsync<ListResultDto<BlogDto>>(nameof(GetListAsync));
    }

    public virtual async Task<BlogDto> GetByShortNameAsync(string shortName)
    {
        return await RequestAsync<BlogDto>(nameof(GetByShortNameAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), shortName }
        });
    }

    public virtual async Task<BlogDto> GetAsync(Guid id)
    {
        return await RequestAsync<BlogDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }
}
