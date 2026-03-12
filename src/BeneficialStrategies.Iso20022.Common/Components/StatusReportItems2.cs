// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes a transaction and its status.
/// </summary>
[IsoId("_Ra7q9tp-Ed-ak6NoX_4Aeg_-898612372")]
[DisplayName("Status Report Items")]
public partial record StatusReportItems2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_Ra7q99p-Ed-ak6NoX_4Aeg_-898612370")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Entity for which the matching application has generated a report.
    /// </summary>
    [IsoId("_Ra7q-Np-Ed-ak6NoX_4Aeg_-898611970")]
    [DisplayName("Reported Entity")]
    [IsoXmlTag("RptdNtty")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<BICIdentification1> ReportedEntity { get; init; } = new ValueList<BICIdentification1>(){};
    
    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_RbFb8Np-Ed-ak6NoX_4Aeg_-898612311")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required BaselineStatus3Code Status { get; init; } 
    
    /// <summary>
    /// Further description of the transaction status.
    /// </summary>
    [IsoId("_RbFb8dp-Ed-ak6NoX_4Aeg_-898612280")]
    [DisplayName("Sub Status")]
    [IsoXmlTag("SubSts")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? SubStatus { get; init; } 
    
    
    #nullable disable
    
}
