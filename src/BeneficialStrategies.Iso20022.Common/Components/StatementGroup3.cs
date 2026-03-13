// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of the statement header reporting the bank services billing and the billing statement.
/// </summary>
[IsoId("_BMC6W249EeiU9cctagi5ow")]
[DisplayName("Statement Group")]
public partial record StatementGroup3
{
    #nullable enable
    
    /// <summary>
    /// Identification of a group of customer billing statements.
    /// </summary>
    [IsoId("_BVSV0W49EeiU9cctagi5ow")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text GroupIdentification { get; init; } 
    
    /// <summary>
    /// Originating financial institution sending the statement.
    /// </summary>
    [IsoId("_BVSV0249EeiU9cctagi5ow")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public required PartyIdentification138 Sender { get; init; } 
    
    /// <summary>
    /// Specifies the individual to contact in case of technical problems at the sender&apos;s location.
    /// </summary>
    [IsoId("_BVSV1W49EeiU9cctagi5ow")]
    [DisplayName("Sender Individual Contact")]
    [IsoXmlTag("SndrIndvCtct")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Contact4> SenderIndividualContact { get; init; } = [];
    
    /// <summary>
    /// Financial institution customer receiving the statement.
    /// </summary>
    [IsoId("_BVSV1249EeiU9cctagi5ow")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public required PartyIdentification138 Receiver { get; init; } 
    
    /// <summary>
    /// Specifies the individual to contact in case of technical problems at the receiver&apos;s location.
    /// </summary>
    [IsoId("_BVSV2W49EeiU9cctagi5ow")]
    [DisplayName("Receiver Individual Contact")]
    [IsoXmlTag("RcvrIndvCtct")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<Contact4> ReceiverIndividualContact { get; init; } = [];
    
    /// <summary>
    /// Provides the bank services billing statement recounting of all service chargeable events that occurred during a reporting cycle, such as the end of the month reporting.
    /// </summary>
    [IsoId("_BVSV2249EeiU9cctagi5ow")]
    [DisplayName("Billing Statement")]
    [IsoXmlTag("BllgStmt")]
    public ValueList<BillingStatement3> BillingStatement { get; init; } = [];
    // ID for the above is _BVSV2249EeiU9cctagi5ow
    
    
    #nullable disable
    
}
