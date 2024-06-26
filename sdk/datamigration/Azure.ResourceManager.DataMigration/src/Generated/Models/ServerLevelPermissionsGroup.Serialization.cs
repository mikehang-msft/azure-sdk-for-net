// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataMigration.Models
{
    internal static partial class ServerLevelPermissionsGroupExtensions
    {
        public static string ToSerialString(this ServerLevelPermissionsGroup value) => value switch
        {
            ServerLevelPermissionsGroup.Default => "Default",
            ServerLevelPermissionsGroup.MigrationFromSqlServerToAzureDB => "MigrationFromSqlServerToAzureDB",
            ServerLevelPermissionsGroup.MigrationFromSqlServerToAzureMI => "MigrationFromSqlServerToAzureMI",
            ServerLevelPermissionsGroup.MigrationFromMySqlToAzureDBForMySql => "MigrationFromMySQLToAzureDBForMySQL",
            ServerLevelPermissionsGroup.MigrationFromSqlServerToAzureVm => "MigrationFromSqlServerToAzureVM",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServerLevelPermissionsGroup value.")
        };

        public static ServerLevelPermissionsGroup ToServerLevelPermissionsGroup(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Default")) return ServerLevelPermissionsGroup.Default;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "MigrationFromSqlServerToAzureDB")) return ServerLevelPermissionsGroup.MigrationFromSqlServerToAzureDB;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "MigrationFromSqlServerToAzureMI")) return ServerLevelPermissionsGroup.MigrationFromSqlServerToAzureMI;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "MigrationFromMySQLToAzureDBForMySQL")) return ServerLevelPermissionsGroup.MigrationFromMySqlToAzureDBForMySql;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "MigrationFromSqlServerToAzureVM")) return ServerLevelPermissionsGroup.MigrationFromSqlServerToAzureVm;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ServerLevelPermissionsGroup value.");
        }
    }
}
