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
/// Contains ticket details. 
/// </summary>
[IsoId("_em5RL_P0EeihCvvpsmGI2w")]
[DisplayName("Ticket")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Ticket1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the ticket number. 
    /// </summary>
    [IsoId("_em5ROPP0EeihCvvpsmGI2w")]
    [DisplayName("Ticket Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TcktNb")]
    #endif
    [IsoXmlTag("TcktNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TicketNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TicketNumber { get; init; } 
    #else
    public System.String? TicketNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the issuing ticket agent. 
    /// </summary>
    [IsoId("_em5RM_P0EeihCvvpsmGI2w")]
    [DisplayName("Ticket Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TcktIssr")]
    #endif
    [IsoXmlTag("TcktIssr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification197? TicketIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification197? TicketIssuer { get; init; } 
    #else
    public PartyIdentification197? TicketIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Date the ticket was issued.
    /// </summary>
    [IsoId("_em5RPPP0EeihCvvpsmGI2w")]
    [DisplayName("Ticket Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TcktIsseDt")]
    #endif
    [IsoXmlTag("TcktIsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TicketIssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TicketIssueDate { get; init; } 
    #else
    public System.DateOnly? TicketIssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Location where ticket was issued.
    /// </summary>
    [IsoId("_em5RN_P0EeihCvvpsmGI2w")]
    [DisplayName("Ticket Issue Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TcktIsseLctn")]
    #endif
    [IsoXmlTag("TcktIsseLctn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? TicketIssueLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TicketIssueLocation { get; init; } 
    #else
    public System.String? TicketIssueLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Number of a ticket that contains additional coupons for an itinerary that contains more than four segments. 
    /// </summary>
    [IsoId("_em5RMvP0EeihCvvpsmGI2w")]
    [DisplayName("Conjunction Ticket Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CnjnctnTcktNb")]
    #endif
    [IsoXmlTag("CnjnctnTcktNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ConjunctionTicketNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConjunctionTicketNumber { get; init; } 
    #else
    public System.String? ConjunctionTicketNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not restrictions apply to the ticket.
    /// True = Restrictions apply
    /// False = Restrictions do not apply
    /// </summary>
    [IsoId("_YZgmkP4gEeix6ug6HlF6IQ")]
    [DisplayName("Restricted Ticket Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctdTcktInd")]
    #endif
    [IsoXmlTag("RstrctdTcktInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RestrictedTicketIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RestrictedTicketIndicator { get; init; } 
    #else
    public System.String? RestrictedTicketIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the ticket is open-ended. 
    /// True = Ticket is open-ended
    /// False = Ticket is not open-ended
    /// </summary>
    [IsoId("_9Q92gP4gEeix6ug6HlF6IQ")]
    [DisplayName("Open Ticket Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpnTcktInd")]
    #endif
    [IsoXmlTag("OpnTcktInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? OpenTicketIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OpenTicketIndicator { get; init; } 
    #else
    public System.String? OpenTicketIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the specific restriction applicable to the ticket.
    /// </summary>
    [IsoId("_cuxWoP4gEeix6ug6HlF6IQ")]
    [DisplayName("Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rstrctns")]
    #endif
    [IsoXmlTag("Rstrctns")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Restrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Restrictions { get; init; } 
    #else
    public System.String? Restrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the ticket was exchanged (reissued or new ticket generated). 
    /// True = Ticket was exchanged
    /// False = Ticket was not exchanged
    /// </summary>
    [IsoId("_z7DQAP4gEeix6ug6HlF6IQ")]
    [DisplayName("Exchanged Ticket Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgdTcktInd")]
    #endif
    [IsoXmlTag("XchgdTcktInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ExchangedTicketIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExchangedTicketIndicator { get; init; } 
    #else
    public System.String? ExchangedTicketIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the original ticket number that was replaced by the new ticket number. 
    /// </summary>
    [IsoId("_qVfrAP4gEeix6ug6HlF6IQ")]
    [DisplayName("Exchanged Ticket Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgdTcktNb")]
    #endif
    [IsoXmlTag("XchgdTcktNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ExchangedTicketNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExchangedTicketNumber { get; init; } 
    #else
    public System.String? ExchangedTicketNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Ticket record locator number.
    /// </summary>
    [IsoId("_em5RPfP0EeihCvvpsmGI2w")]
    [DisplayName("Record Locator Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdLctrNb")]
    #endif
    [IsoXmlTag("RcrdLctrNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RecordLocatorNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RecordLocatorNumber { get; init; } 
    #else
    public System.String? RecordLocatorNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reservation number or identifier. 
    /// </summary>
    [IsoId("_em5ROvP0EeihCvvpsmGI2w")]
    [DisplayName("Reservation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsvatn")]
    #endif
    [IsoXmlTag("Rsvatn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReservationDetails3? Reservation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationDetails3? Reservation { get; init; } 
    #else
    public ReservationDetails3? Reservation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
