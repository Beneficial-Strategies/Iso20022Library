// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_-boSIWZ3EeSQMqOS_ceSQA")]
[DisplayName("Charge")]
public partial record Charge27
{
    #nullable enable
    
    /// <summary>
    /// Type of charge.
    /// </summary>
    [IsoId("_RDZegGZ4EeSQMqOS_ceSQA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType4Choice_ Type { get; init; } 
    
    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_-2j6qWZ3EeSQMqOS_ceSQA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Method used to calculate the charge.
    /// </summary>
    [IsoId("_LfQrEGZ5EeSQMqOS_ceSQA")]
    [DisplayName("Charge Basis")]
    [IsoXmlTag("ChrgBsis")]
    public ChargeBasisType1Choice_? ChargeBasis { get; init; } 
    
    /// <summary>
    /// Specifies the party that will bear the charges associated with a transfer.
    /// </summary>
    [IsoId("_f9ilwWZ8EeSQMqOS_ceSQA")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearer1Code? ChargeBearer { get; init; } 
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a charge.
    /// </summary>
    [IsoId("_-2j6sWZ3EeSQMqOS_ceSQA")]
    [DisplayName("Recipient Identification")]
    [IsoXmlTag("RcptId")]
    public PartyIdentification2Choice_? RecipientIdentification { get; init; } 
    
    
    #nullable disable
    
}
