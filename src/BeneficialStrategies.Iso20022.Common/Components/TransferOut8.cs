// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the confirmation of a transfer out transaction.
/// </summary>
[IsoId("_ucCWIfr2EeCJc7cZxzE2fg")]
[DisplayName("Transfer Out")]
public partial record TransferOut8
{
    #nullable enable
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_ucCWJ_r2EeCJc7cZxzE2fg")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public ValueList<Transfer14> TransferDetails { get; init; } = [];
    // ID for the above is _ucCWJ_r2EeCJc7cZxzE2fg
    
    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    [IsoId("_ucCWL_r2EeCJc7cZxzE2fg")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount22 AccountDetails { get; init; } 
    
    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_ucCWM_r2EeCJc7cZxzE2fg")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required ReceiveInformation8 SettlementDetails { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_ucCWN_r2EeCJc7cZxzE2fg")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}
