// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for an allegement status.
    /// </summary>
    [KnownType(typeof(PortfolioTransferStatus2Choice.AcknowledgedAccepted))]
    [KnownType(typeof(PortfolioTransferStatus2Choice.PendingProcessing))]
    [KnownType(typeof(PortfolioTransferStatus2Choice.Rejected))]
    [KnownType(typeof(PortfolioTransferStatus2Choice.Proprietary))]
    [JsonDerivedType(typeof(PortfolioTransferStatus2Choice.AcknowledgedAccepted),nameof(PortfolioTransferStatus2Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(PortfolioTransferStatus2Choice.PendingProcessing),nameof(PortfolioTransferStatus2Choice.PendingProcessing))]
    [JsonDerivedType(typeof(PortfolioTransferStatus2Choice.Rejected),nameof(PortfolioTransferStatus2Choice.Rejected))]
    [JsonDerivedType(typeof(PortfolioTransferStatus2Choice.Proprietary),nameof(PortfolioTransferStatus2Choice.Proprietary))]
    [IsoId("_bClDsekGEemm4qhb2yFPOw")]
    [DisplayName("Portfolio Transfer Status 2 Choice")]
    public abstract partial record PortfolioTransferStatus2Choice_
    {
    }
}
