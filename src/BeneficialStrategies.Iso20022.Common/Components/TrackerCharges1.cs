// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the charges related to the payment transaction.
/// </summary>
[IsoId("_XaHJxfWfEemtd4wHZYvFUQ")]
[DisplayName("Tracker Charges")]
public partial record TrackerCharges1
{
    #nullable enable
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    [IsoId("_XaHJyfWfEemtd4wHZYvFUQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required RestrictedFINActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    [IsoId("_XaHJy_WfEemtd4wHZYvFUQ")]
    [DisplayName("Agent")]
    [IsoXmlTag("Agt")]
    public required TrackerFinancialInstitutionIdentification1 Agent { get; init; } 
    
    
    #nullable disable
    
}
