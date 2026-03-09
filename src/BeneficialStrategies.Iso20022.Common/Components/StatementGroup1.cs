// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Group of the statement header reporting the bank services billing and the billing statement.
/// </summary>
[IsoId("_6QsqlZqlEeGSON8vddiWzQ_1977241265")]
[DisplayName("Statement Group")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatementGroup1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatementGroup1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatementGroup1( System.String reqGroupIdentification,PartyIdentification58 reqSender,PartyIdentification58 reqReceiver )
    {
        GroupIdentification = reqGroupIdentification;
        Sender = reqSender;
        Receiver = reqReceiver;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a group of customer billing statements.
    /// </summary>
    [IsoId("_6QsqlpqlEeGSON8vddiWzQ_379980943")]
    [DisplayName("Group Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpId")]
    #endif
    [IsoXmlTag("GrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text GroupIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String GroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String GroupIdentification { get; init; } 
    #else
    public System.String GroupIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Originating financial institution sending the statement.
    /// </summary>
    [IsoId("_6Qsql5qlEeGSON8vddiWzQ_1508697108")]
    [DisplayName("Sender")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sndr")]
    #endif
    [IsoXmlTag("Sndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification58 Sender { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification58 Sender { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification58 Sender { get; init; } 
    #else
    public PartyIdentification58 Sender { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the individual to contact in case of technical problems at the sender&apos;s location.
    /// </summary>
    [IsoId("_6QsqmJqlEeGSON8vddiWzQ_1946121169")]
    [DisplayName("Sender Individual Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrIndvCtct")]
    #endif
    [IsoXmlTag("SndrIndvCtct")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<ContactDetails3> SenderIndividualContact { get; init; } = new ValueList<ContactDetails3>(){};
    
    /// <summary>
    /// Financial institution customer receiving the statement.
    /// </summary>
    [IsoId("_6Q10gJqlEeGSON8vddiWzQ_-1355948140")]
    [DisplayName("Receiver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcvr")]
    #endif
    [IsoXmlTag("Rcvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification58 Receiver { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification58 Receiver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification58 Receiver { get; init; } 
    #else
    public PartyIdentification58 Receiver { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the individual to contact in case of technical problems at the receiver&apos;s location.
    /// </summary>
    [IsoId("_6Q10gZqlEeGSON8vddiWzQ_1985160880")]
    [DisplayName("Receiver Individual Contact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvrIndvCtct")]
    #endif
    [IsoXmlTag("RcvrIndvCtct")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<ContactDetails3> ReceiverIndividualContact { get; init; } = new ValueList<ContactDetails3>(){};
    
    /// <summary>
    /// Provides the bank services billing statement recounting of all service chargeable events that occurred during a reporting cycle, such as the end of the month reporting.
    /// </summary>
    [IsoId("_6Q10gpqlEeGSON8vddiWzQ_-1643820345")]
    [DisplayName("Billing Statement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BllgStmt")]
    #endif
    [IsoXmlTag("BllgStmt")]
    public ValueList<BillingStatement1> BillingStatement { get; init; } = new ValueList<BillingStatement1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _6Q10gpqlEeGSON8vddiWzQ_-1643820345
    
    
    #nullable disable
    
}
