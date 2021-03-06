﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.XF.AppInstallHelper.Abstractions
{

    public enum InstallMode
    {
        /// <summary>
        /// Android : Downloaded Apk file
        /// iOS : Enterprise distribution
        /// </summary>
        OutOfAppStore = 0,
        /// <summary>
        /// Android : Google play store
        /// iOS : Apple App store
        /// </summary>
        AppStore = 1
    }

    public interface IHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileProviderAuthorities">packageName.fileprovider</param>
        void Init(string fileProviderAuthorities);

        /// <summary>
        /// Install the application package
        /// </summary>
        /// <param name="path"></param>
        /// <param name="installMode"></param>
        Task<bool> InstallApp(string path, InstallMode installMode);

        /// <summary>
        /// Get the Public Download File path for OS
        /// </summary>
        /// <returns></returns>
        string GetPublicDownloadPath();

        /// <summary>
        /// Ask for permission on storage read/write
        /// </summary>
        Task<bool> AskForRequiredPermission();
    }
}
