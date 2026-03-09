// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for an allegement status.
    /// </summary>
    [KnownType(typeof(PortfolioTransferStatus2Choice.AcknowledgedAccepted))]
    [KnownType(typeof(PortfolioTransferStatus2Choice.PendingProcessing))]
    [KnownType(typeof(PortfolioTransferStatus2Choice.Rejected))]
    [KnownType(typeof(PortfolioTransferStatus2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PortfolioTransferStatus2Choice.AcknowledgedAccepted),nameof(PortfolioTransferStatus2Choice.AcknowledgedAccepted))]
    [JsonDerivedType(typeof(PortfolioTransferStatus2Choice.PendingProcessing),nameof(PortfolioTransferStatus2Choice.PendingProcessing))]
    [JsonDerivedType(typeof(PortfolioTransferStatus2Choice.Rejected),nameof(PortfolioTransferStatus2Choice.Rejected))]
    [JsonDerivedType(typeof(PortfolioTransferStatus2Choice.Proprietary),nameof(PortfolioTransferStatus2Choice.Proprietary))]
    #endif
    [IsoId("_bClDsekGEemm4qhb2yFPOw")]
    [DisplayName("Portfolio Transfer Status 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PortfolioTransferStatus2Choice_
    #else
    public abstract partial class PortfolioTransferStatus2Choice_
    #endif
    {
    }
}
