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
/// Parameters applied to the settlement of a security transfer.
/// </summary>
[IsoId("_QVV74tp-Ed-ak6NoX_4Aeg_1340706993")]
[DisplayName("Fund Settlement Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundSettlementParameters3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FundSettlementParameters3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FundSettlementParameters3( PartyIdentification2Choice_ reqSettlementPlace,DeliveringPartiesAndAccount3 reqDeliveringSideDetails )
    {
        SettlementPlace = reqSettlementPlace;
        DeliveringSideDetails = reqDeliveringSideDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_QVV749p-Ed-ak6NoX_4Aeg_1340707070")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SettlementDate { get; init; } 
    #else
    public System.DateOnly? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the settlement of transaction will take place. In the context of the investment funds, the place of settlement is the transfer agent, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_QVV75Np-Ed-ak6NoX_4Aeg_1340707019")]
    [DisplayName("Settlement Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPlc")]
    #endif
    [IsoXmlTag("SttlmPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification2Choice_ SettlementPlace { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification2Choice_ SettlementPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_ SettlementPlace { get; init; } 
    #else
    public PartyIdentification2Choice_ SettlementPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    [IsoId("_QVV75dp-Ed-ak6NoX_4Aeg_1340707028")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? SafekeepingPlace { get; init; } 
    #else
    public PartyIdentification2Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the securities settlement system to be used.
    /// </summary>
    [IsoId("_QVV75tp-Ed-ak6NoX_4Aeg_1340707053")]
    [DisplayName("Securities Settlement System Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesSttlmSysId")]
    #endif
    [IsoXmlTag("SctiesSttlmSysId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesSettlementSystemIdentification { get; init; } 
    #else
    public System.String? SecuritiesSettlementSystemIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("_QVV759p-Ed-ak6NoX_4Aeg_1340707149")]
    [DisplayName("Receiving Side Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSdDtls")]
    #endif
    [IsoXmlTag("RcvgSdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReceivingPartiesAndAccount3? ReceivingSideDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceivingPartiesAndAccount3? ReceivingSideDetails { get; init; } 
    #else
    public ReceivingPartiesAndAccount3? ReceivingSideDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction resulting in the movement of a security from one account to another.
    /// </summary>
    [IsoId("_QVV76Np-Ed-ak6NoX_4Aeg_1340707120")]
    [DisplayName("Delivering Side Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSdDtls")]
    #endif
    [IsoXmlTag("DlvrgSdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DeliveringPartiesAndAccount3 DeliveringSideDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DeliveringPartiesAndAccount3 DeliveringSideDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveringPartiesAndAccount3 DeliveringSideDetails { get; init; } 
    #else
    public DeliveringPartiesAndAccount3 DeliveringSideDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
