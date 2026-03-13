// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the confirmation of a transfer in transaction.
/// </summary>
[IsoId("_j9WUd_r3EeCJc7cZxzE2fg")]
[DisplayName("Transfer In")]
public partial record TransferIn6
{
    #nullable enable
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_j9WUffr3EeCJc7cZxzE2fg")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public ValueList<Transfer17> TransferDetails { get; init; } = [];
    // ID for the above is _j9WUffr3EeCJc7cZxzE2fg
    
    /// <summary>
    /// Information related to the account into which the financial instrument was received.
    /// </summary>
    [IsoId("_j9WUhfr3EeCJc7cZxzE2fg")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount22 AccountDetails { get; init; } 
    
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_j9WUifr3EeCJc7cZxzE2fg")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required DeliverInformation7 SettlementDetails { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_j9WUjfr3EeCJc7cZxzE2fg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
