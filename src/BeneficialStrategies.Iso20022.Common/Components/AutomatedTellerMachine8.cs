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
/// ATM information.
/// </summary>
[IsoId("_obBZsYtuEeSLQutgI1Ulfw")]
[DisplayName("Automated Teller Machine")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AutomatedTellerMachine8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AutomatedTellerMachine8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AutomatedTellerMachine8( System.String reqIdentification,string reqBaseCurrency )
    {
        Identification = reqIdentification;
        BaseCurrency = reqBaseCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// ATM terminal device identification for the acquirer and the issuer.
    /// </summary>
    [IsoId("_on_esYtuEeSLQutgI1Ulfw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// ATM terminal device identification for the ATM manager.
    /// </summary>
    [IsoId("_on_es4tuEeSLQutgI1Ulfw")]
    [DisplayName("Additional Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlId")]
    #endif
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AdditionalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalIdentification { get; init; } 
    #else
    public System.String? AdditionalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// ATM terminal device identification for the branch.
    /// </summary>
    [IsoId("_on_etYtuEeSLQutgI1Ulfw")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SequenceNumber { get; init; } 
    #else
    public System.String? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Reference currency of the ATM.
    /// </summary>
    [IsoId("_on_et4tuEeSLQutgI1Ulfw")]
    [DisplayName("Base Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BaseCcy")]
    #endif
    [IsoXmlTag("BaseCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode BaseCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string BaseCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string BaseCurrency { get; init; } 
    #else
    public string BaseCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the ATM.
    /// </summary>
    [IsoId("_on_euYtuEeSLQutgI1Ulfw")]
    [DisplayName("Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lctn")]
    #endif
    [IsoXmlTag("Lctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PostalAddress17? Location { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress17? Location { get; init; } 
    #else
    public PostalAddress17? Location { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the environment of the transaction.
    /// </summary>
    [IsoId("_on_eu4tuEeSLQutgI1Ulfw")]
    [DisplayName("Location Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LctnCtgy")]
    #endif
    [IsoXmlTag("LctnCtgy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionEnvironment2Code? LocationCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionEnvironment2Code? LocationCategory { get; init; } 
    #else
    public TransactionEnvironment2Code? LocationCategory { get; set; } 
    #endif
    
    /// <summary>
    /// ATM terminal equipment.
    /// </summary>
    [IsoId("_on_evYtuEeSLQutgI1Ulfw")]
    [DisplayName("Equipment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Eqpmnt")]
    #endif
    [IsoXmlTag("Eqpmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMEquipment1? Equipment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEquipment1? Equipment { get; init; } 
    #else
    public ATMEquipment1? Equipment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
