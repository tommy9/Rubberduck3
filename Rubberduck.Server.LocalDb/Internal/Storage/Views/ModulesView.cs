﻿using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Threading.Tasks;
using Rubberduck.Server.LocalDb.Internal.Storage.Abstract;
using Rubberduck.Server.LocalDb.Internal.Model;

namespace Rubberduck.Server.LocalDb.Internal.Storage
{
    internal class ModulesView : View<ModuleInfo>
    {
        public ModulesView(IDbConnection connection)
            : base(connection) { }

        protected override string[] ColumnNames { get; } = new[]
        {
            "Id",
            "Folder",
            "DeclarationId",
            "DeclarationType",
            "IdentifierName",
            "DocString",
            "IsUserDefined",
            "ProjectDeclarationId",
            "ProjectName",
            "VBProjectId",
        };

        protected override string Source { get; } = "[Modules_v1]";

        public async Task<IEnumerable<ModuleInfo>> GetByProjectDeclarationId(int id)
        {
            var sql = $"SELECT {Columns} FROM {Source} WHERE [ProjectDeclarationId] = @id";
            return await Database.QueryAsync<ModuleInfo>(sql, id);
        }
    }
}