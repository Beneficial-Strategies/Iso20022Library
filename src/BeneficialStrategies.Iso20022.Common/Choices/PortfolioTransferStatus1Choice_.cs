// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allegement status.
    /// </summary>
    [KnownType(typeof(PortfolioTransferStatus1Choice.Code))]
    [KnownType(typeof(PortfolioTransferStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(PortfolioTransferStatus1Choice.Code),nameof(PortfolioTransferStatus1Choice.Code))]
    [JsonDerivedType(typeof(PortfolioTransferStatus1Choice.Proprietary),nameof(PortfolioTransferStatus1Choice.Proprietary))]
    [IsoId("_A91Owa3EEeeBVbuVcoH9Nw")]
    [DisplayName("Portfolio Transfer Status 1 Choice")]
    public abstract partial record PortfolioTransferStatus1Choice_
    {
    }
}
