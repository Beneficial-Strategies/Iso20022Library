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
[IsoId("_6QsqlZqlEeGSON8vddiWzQ_1977241265")]
[DisplayName("Statement Group")]
public partial record StatementGroup1
{
    #nullable enable
    
    /// <summary>
    /// Identification of a group of customer billing statements.
    /// </summary>
    [IsoId("_6QsqlpqlEeGSON8vddiWzQ_379980943")]
    [DisplayName("Group Identification")]
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text GroupIdentification { get; init; } 
    
    /// <summary>
    /// Originating financial institution sending the statement.
    /// </summary>
    [IsoId("_6Qsql5qlEeGSON8vddiWzQ_1508697108")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public required PartyIdentification58 Sender { get; init; } 
    
    /// <summary>
    /// Specifies the individual to contact in case of technical problems at the sender&apos;s location.
    /// </summary>
    [IsoId("_6QsqmJqlEeGSON8vddiWzQ_1946121169")]
    [DisplayName("Sender Individual Contact")]
    [IsoXmlTag("SndrIndvCtct")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<ContactDetails3> SenderIndividualContact { get; init; } = new ValueList<ContactDetails3>(){};
    
    /// <summary>
    /// Financial institution customer receiving the statement.
    /// </summary>
    [IsoId("_6Q10gJqlEeGSON8vddiWzQ_-1355948140")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public required PartyIdentification58 Receiver { get; init; } 
    
    /// <summary>
    /// Specifies the individual to contact in case of technical problems at the receiver&apos;s location.
    /// </summary>
    [IsoId("_6Q10gZqlEeGSON8vddiWzQ_1985160880")]
    [DisplayName("Receiver Individual Contact")]
    [IsoXmlTag("RcvrIndvCtct")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<ContactDetails3> ReceiverIndividualContact { get; init; } = new ValueList<ContactDetails3>(){};
    
    /// <summary>
    /// Provides the bank services billing statement recounting of all service chargeable events that occurred during a reporting cycle, such as the end of the month reporting.
    /// </summary>
    [IsoId("_6Q10gpqlEeGSON8vddiWzQ_-1643820345")]
    [DisplayName("Billing Statement")]
    [IsoXmlTag("BllgStmt")]
    public ValueList<BillingStatement1> BillingStatement { get; init; } = new ValueList<BillingStatement1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _6Q10gpqlEeGSON8vddiWzQ_-1643820345
    
    
    #nullable disable
    
}
