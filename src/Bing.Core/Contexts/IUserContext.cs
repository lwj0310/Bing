﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Contexts
{
    /// <summary>
    /// 用户上下文
    /// </summary>
    public interface IUserContext
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        string UserId { get; }

        /// <summary>
        /// 用户名
        /// </summary>
        string UserName { get;}

        /// <summary>
        /// 租户ID
        /// </summary>
        string TenantId { get; }

        /// <summary>
        /// 获取上下文信息
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="key">键</param>
        /// <returns></returns>
        T GetContextInfo<T>(string key);
    }
}
