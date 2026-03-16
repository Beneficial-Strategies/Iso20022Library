// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Abort Data6.
/// </summary>
[IsoId("_Bpy0cZFIEe6reqfAp4CunQ")]
[DisplayName("Abort Data6")]
public partial record AbortData6
{
    #nullable enable

    /// <summary>
    /// Abort Reason.
    /// </summary>
    [DisplayName("Abort Reason")]
    [IsoXmlTag("AbrtRsn")]
    public required IsoMax140Text AbortReason { get; init; } 

    /// <summary>
    /// Display Output.
    /// </summary>
    [DisplayName("Display Output")]
    [IsoXmlTag("DispOutpt")]
    public ActionMessage11? DisplayOutput { get; init; } 

    /// <summary>
    /// Exchange Identification.
    /// </summary>
    [DisplayName("Exchange Identification")]
    [IsoXmlTag("XchgId")]
    public required IsoMax35Text ExchangeIdentification { get; init; } 

    /// <summary>
    /// Transaction Success.
    /// </summary>
    [DisplayName("Transaction Success")]
    [IsoXmlTag("TxSucss")]
    public IsoTrueFalseIndicator? TransactionSuccess { get; init; } 

    
    #nullable disable
    
}
