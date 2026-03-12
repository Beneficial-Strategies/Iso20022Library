// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the block trade information.
    /// </summary>
    [KnownType(typeof(BlockTrade1Choice.Code))]
    [KnownType(typeof(BlockTrade1Choice.Proprietary))]
    [JsonDerivedType(typeof(BlockTrade1Choice.Code),nameof(BlockTrade1Choice.Code))]
    [JsonDerivedType(typeof(BlockTrade1Choice.Proprietary),nameof(BlockTrade1Choice.Proprietary))]
    [IsoId("_QvuKwtp-Ed-ak6NoX_4Aeg_333347197")]
    [DisplayName("Block Trade 1 Choice")]
    public abstract partial record BlockTrade1Choice_
    {
    }
}
