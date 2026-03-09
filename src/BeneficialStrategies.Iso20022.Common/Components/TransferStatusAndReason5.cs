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
/// Information about the status of a transfer instruction and its reason.
/// </summary>
[IsoId("_FjDpwYfuEeevKP8c-ilVhA")]
[DisplayName("Transfer Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferStatusAndReason5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferStatusAndReason5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferStatusAndReason5( System.String reqTransferReference,TransferStatus2Choice_ reqTransferStatus )
    {
        TransferReference = reqTransferReference;
        TransferStatus = reqTransferStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_Fzt784fuEeevKP8c-ilVhA")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification of the transfer, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Fzt79YfuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfRef")]
    #endif
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransferReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransferReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransferReference { get; init; } 
    #else
    public System.String TransferReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of the transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [IsoId("_Fzt794fuEeevKP8c-ilVhA")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference7? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference7? ClientReference { get; init; } 
    #else
    public AdditionalReference7? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Fzt7-YfuEeevKP8c-ilVhA")]
    [DisplayName("Cancellation Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRef")]
    #endif
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CancellationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationReference { get; init; } 
    #else
    public System.String? CancellationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_Fzt7-4fuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfSts")]
    #endif
    [IsoXmlTag("TrfSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferStatus2Choice_ TransferStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferStatus2Choice_ TransferStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferStatus2Choice_ TransferStatus { get; init; } 
    #else
    public TransferStatus2Choice_ TransferStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [IsoId("_Fzt7_YfuEeevKP8c-ilVhA")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TradeDate { get; init; } 
    #else
    public System.DateOnly? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the document, for example, the application form, was sent.
    /// </summary>
    [IsoId("_Fzt7_4fuEeevKP8c-ilVhA")]
    [DisplayName("Send Out Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndOutDt")]
    #endif
    [IsoXmlTag("SndOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SendOutDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SendOutDate { get; init; } 
    #else
    public System.DateOnly? SendOutDate { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units to be transferred.
    /// </summary>
    [IsoId("_2k8swYmPEeeJpL7HBafurA")]
    [DisplayName("Total Units Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlUnitsNb")]
    #endif
    [IsoXmlTag("TtlUnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? TotalUnitsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalUnitsNumber { get; init; } 
    #else
    public System.UInt64? TotalUnitsNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Weighted average price of the units in the account. The AveragePrice may also be known as the average acquisition price.
    /// </summary>
    [IsoId("_Tr7C8YmQEeeJpL7HBafurA")]
    [DisplayName("Average Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgPric")]
    #endif
    [IsoXmlTag("AvrgPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of units to be transferred.
    /// </summary>
    [IsoId("_B1vy8ImNEeeJpL7HBafurA")]
    [DisplayName("Units Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsDtls")]
    #endif
    [IsoXmlTag("UnitsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Unit8? UnitsDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Unit8? UnitsDetails { get; init; } 
    #else
    public Unit8? UnitsDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status.
    /// </summary>
    [IsoId("_Fzt8AYfuEeevKP8c-ilVhA")]
    [DisplayName("Status Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInitr")]
    #endif
    [IsoXmlTag("StsInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification113? StatusInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification113? StatusInitiator { get; init; } 
    #else
    public PartyIdentification113? StatusInitiator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
