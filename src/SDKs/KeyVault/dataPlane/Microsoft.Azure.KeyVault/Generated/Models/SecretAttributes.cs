// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using Azure;
    using KeyVault;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The secret management attributes.
    /// </summary>
    public partial class SecretAttributes : Attributes
    {
        /// <summary>
        /// Initializes a new instance of the SecretAttributes class.
        /// </summary>
        public SecretAttributes() { }

        /// <summary>
        /// Initializes a new instance of the SecretAttributes class.
        /// </summary>
        /// <param name="enabled">Determines whether the object is
        /// enabled.</param>
        /// <param name="notBefore">Not before date in UTC.</param>
        /// <param name="expires">Expiry date in UTC.</param>
        /// <param name="created">Creation time in UTC.</param>
        /// <param name="updated">Last updated time in UTC.</param>
        /// <param name="recoveryLevel">Reflects the deletion recovery level
        /// currently in effect for secrets in the current vault. If it
        /// contains 'Purgeable', the secret can be permanently deleted by a
        /// privileged user; otherwise, only the system can purge the secret,
        /// at the end of the retention interval. Possible values include:
        /// 'Purgeable', 'Recoverable+Purgeable', 'Recoverable',
        /// 'Recoverable+ProtectedSubscription'</param>
        public SecretAttributes(bool? enabled = default(bool?), System.DateTime? notBefore = default(System.DateTime?), System.DateTime? expires = default(System.DateTime?), System.DateTime? created = default(System.DateTime?), System.DateTime? updated = default(System.DateTime?), string recoveryLevel = default(string))
            : base(enabled, notBefore, expires, created, updated)
        {
            RecoveryLevel = recoveryLevel;
        }

        /// <summary>
        /// Gets reflects the deletion recovery level currently in effect for
        /// secrets in the current vault. If it contains 'Purgeable', the
        /// secret can be permanently deleted by a privileged user; otherwise,
        /// only the system can purge the secret, at the end of the retention
        /// interval. Possible values include: 'Purgeable',
        /// 'Recoverable+Purgeable', 'Recoverable',
        /// 'Recoverable+ProtectedSubscription'
        /// </summary>
        [JsonProperty(PropertyName = "recoveryLevel")]
        public string RecoveryLevel { get; protected set; }

    }
}

