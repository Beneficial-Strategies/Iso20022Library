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
/// Container for tenders used by the customer to perform the payment transaction.
/// </summary>
[IsoId("_i-iXYZlYEeu76rs9yGlfEg")]
[DisplayName("Wallet")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Wallet2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the provider of the wallet.
    /// </summary>
    [IsoId("_jFQqcZlYEeu76rs9yGlfEg")]
    [DisplayName("Provider")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prvdr")]
    #endif
    [IsoXmlTag("Prvdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification258? Provider { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification258? Provider { get; init; } 
    #else
    public PartyIdentification258? Provider { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days that the user’s PAN has been on file for the user.
    /// </summary>
    [IsoId("_JWlQUJlZEeu76rs9yGlfEg")]
    [DisplayName("PAN Age")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PANAge")]
    #endif
    [IsoXmlTag("PANAge")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5PositiveNumber? PANAge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? PANAge { get; init; } 
    #else
    public System.UInt64? PANAge { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days since the user wallet account for this user exists.
    /// </summary>
    [IsoId("_Oq3_AJlaEeu76rs9yGlfEg")]
    [DisplayName("User Account Age")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsrAcctAge")]
    #endif
    [IsoXmlTag("UsrAcctAge")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5PositiveNumber? UserAccountAge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? UserAccountAge { get; init; } 
    #else
    public System.UInt64? UserAccountAge { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days since the user created the wallet account or started using the wallet.
    /// </summary>
    [IsoId("_TudNoJlaEeu76rs9yGlfEg")]
    [DisplayName("Wallet Account Age")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WlltAcctAge")]
    #endif
    [IsoXmlTag("WlltAcctAge")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5PositiveNumber? WalletAccountAge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? WalletAccountAge { get; init; } 
    #else
    public System.UInt64? WalletAccountAge { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days since the last activity on the wallet.
    /// </summary>
    [IsoId("_ZWVcIJlaEeu76rs9yGlfEg")]
    [DisplayName("Days Since Last Activity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DaysSncLastActvty")]
    #endif
    [IsoXmlTag("DaysSncLastActvty")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5PositiveNumber? DaysSinceLastActivity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? DaysSinceLastActivity { get; init; } 
    #else
    public System.UInt64? DaysSinceLastActivity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of transactions on this wallet within an interval.
    /// </summary>
    [IsoId("_fXxaIJlaEeu76rs9yGlfEg")]
    [DisplayName("Activity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actvty")]
    #endif
    [IsoXmlTag("Actvty")]
    [IsoSimpleType(IsoSimpleType.Max10PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10PositiveNumber? Activity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Activity { get; init; } 
    #else
    public System.UInt64? Activity { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the interval of the activity.
    /// </summary>
    [IsoId("_IjNAsJlbEeu76rs9yGlfEg")]
    [DisplayName("Activity Interval")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtyIntrvl")]
    #endif
    [IsoXmlTag("ActvtyIntrvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Frequency12Code? ActivityInterval { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Frequency12Code? ActivityInterval { get; init; } 
    #else
    public Frequency12Code? ActivityInterval { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days since wallet settings were changed.
    /// </summary>
    [IsoId("_fwDh0JlbEeu76rs9yGlfEg")]
    [DisplayName("Last Wallet Change")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastWlltChng")]
    #endif
    [IsoXmlTag("LastWlltChng")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5PositiveNumber? LastWalletChange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? LastWalletChange { get; init; } 
    #else
    public System.UInt64? LastWalletChange { get; set; } 
    #endif
    
    /// <summary>
    /// Number of cards suspended in the wallet.
    /// </summary>
    [IsoId("_laUV8JlbEeu76rs9yGlfEg")]
    [DisplayName("Suspended Cards")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SspdCrds")]
    #endif
    [IsoXmlTag("SspdCrds")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5PositiveNumber? SuspendedCards { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SuspendedCards { get; init; } 
    #else
    public System.UInt64? SuspendedCards { get; set; } 
    #endif
    
    /// <summary>
    /// Country of the wallet account.
    /// </summary>
    [IsoId("_vOvn8JlcEeu76rs9yGlfEg")]
    [DisplayName("Wallet Account Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WlltAcctCtry")]
    #endif
    [IsoXmlTag("WlltAcctCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOMax3ACountryCode? WalletAccountCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? WalletAccountCountry { get; init; } 
    #else
    public string? WalletAccountCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Method used to capture the card details for the wallet.
    /// </summary>
    [IsoId("_rkwssJlgEeu76rs9yGlfEg")]
    [DisplayName("Card Data Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CardDataNtryMd")]
    #endif
    [IsoXmlTag("CardDataNtryMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDataReading9Code? CardDataEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDataReading9Code? CardDataEntryMode { get; init; } 
    #else
    public CardDataReading9Code? CardDataEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Other method used to capture the card details.
    /// </summary>
    [IsoId("_1FNIMJlgEeu76rs9yGlfEg")]
    [DisplayName("Other Card Data Entry Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCardDataNtryMd")]
    #endif
    [IsoXmlTag("OthrCardDataNtryMd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherCardDataEntryMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherCardDataEntryMode { get; init; } 
    #else
    public System.String? OtherCardDataEntryMode { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days the email address has been in the wallet.
    /// </summary>
    [IsoId("_CoEQQJlhEeu76rs9yGlfEg")]
    [DisplayName("Wallet Account Email Age")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WlltAcctEmailAge")]
    #endif
    [IsoXmlTag("WlltAcctEmailAge")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5PositiveNumber? WalletAccountEmailAge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? WalletAccountEmailAge { get; init; } 
    #else
    public System.UInt64? WalletAccountEmailAge { get; set; } 
    #endif
    
    /// <summary>
    /// Wallet Provider Risk Assessment.
    /// </summary>
    [IsoId("_JJjDcJllEeu76rs9yGlfEg")]
    [DisplayName("Wallet Provider Risk Assessment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WlltPrvdrRskAssmnt")]
    #endif
    [IsoXmlTag("WlltPrvdrRskAssmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RiskAssessment1Code? WalletProviderRiskAssessment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RiskAssessment1Code? WalletProviderRiskAssessment { get; init; } 
    #else
    public RiskAssessment1Code? WalletProviderRiskAssessment { get; set; } 
    #endif
    
    /// <summary>
    /// Wallet Provider Risk Assessment Model Version used to create scores.
    /// </summary>
    [IsoId("_8LKhcJlkEeu76rs9yGlfEg")]
    [DisplayName("Wallet Provider Risk Assessment Model Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WlltPrvdrRskAssmntMdlVrsn")]
    #endif
    [IsoXmlTag("WlltPrvdrRskAssmntMdlVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? WalletProviderRiskAssessmentModelVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WalletProviderRiskAssessmentModelVersion { get; init; } 
    #else
    public System.String? WalletProviderRiskAssessmentModelVersion { get; set; } 
    #endif
    
    /// <summary>
    /// A value to determine trust level of the phone number.
    /// </summary>
    [IsoId("_Wc6-AJllEeu76rs9yGlfEg")]
    [DisplayName("Wallet Provider Phone Score")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WlltPrvdrPhneScore")]
    #endif
    [IsoXmlTag("WlltPrvdrPhneScore")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5PositiveNumber? WalletProviderPhoneScore { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? WalletProviderPhoneScore { get; init; } 
    #else
    public System.UInt64? WalletProviderPhoneScore { get; set; } 
    #endif
    
    /// <summary>
    /// A value to determine trust level of the device.
    /// </summary>
    [IsoId("_hZFJkJllEeu76rs9yGlfEg")]
    [DisplayName("Wallet Provider Device Score")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WlltPrvdrDvcScore")]
    #endif
    [IsoXmlTag("WlltPrvdrDvcScore")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5PositiveNumber? WalletProviderDeviceScore { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? WalletProviderDeviceScore { get; init; } 
    #else
    public System.UInt64? WalletProviderDeviceScore { get; set; } 
    #endif
    
    /// <summary>
    /// A value to determine trust level of the account.
    /// </summary>
    [IsoId("_1w3iEJllEeu76rs9yGlfEg")]
    [DisplayName("Wallet Provider Account Score")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WlltPrvdrAcctScore")]
    #endif
    [IsoXmlTag("WlltPrvdrAcctScore")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5PositiveNumber? WalletProviderAccountScore { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? WalletProviderAccountScore { get; init; } 
    #else
    public System.UInt64? WalletProviderAccountScore { get; set; } 
    #endif
    
    /// <summary>
    /// Additional data associated with wallet.
    /// </summary>
    [IsoId("_jFQqc5lYEeu76rs9yGlfEg")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
