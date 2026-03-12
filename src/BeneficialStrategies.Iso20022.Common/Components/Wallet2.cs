// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Container for tenders used by the customer to perform the payment transaction.
/// </summary>
[IsoId("_i-iXYZlYEeu76rs9yGlfEg")]
[DisplayName("Wallet")]
public partial record Wallet2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the provider of the wallet.
    /// </summary>
    [IsoId("_jFQqcZlYEeu76rs9yGlfEg")]
    [DisplayName("Provider")]
    [IsoXmlTag("Prvdr")]
    public PartyIdentification258? Provider { get; init; } 
    
    /// <summary>
    /// Number of days that the user’s PAN has been on file for the user.
    /// </summary>
    [IsoId("_JWlQUJlZEeu76rs9yGlfEg")]
    [DisplayName("PAN Age")]
    [IsoXmlTag("PANAge")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    public IsoMax5PositiveNumber? PANAge { get; init; } 
    
    /// <summary>
    /// Number of days since the user wallet account for this user exists.
    /// </summary>
    [IsoId("_Oq3_AJlaEeu76rs9yGlfEg")]
    [DisplayName("User Account Age")]
    [IsoXmlTag("UsrAcctAge")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    public IsoMax5PositiveNumber? UserAccountAge { get; init; } 
    
    /// <summary>
    /// Number of days since the user created the wallet account or started using the wallet.
    /// </summary>
    [IsoId("_TudNoJlaEeu76rs9yGlfEg")]
    [DisplayName("Wallet Account Age")]
    [IsoXmlTag("WlltAcctAge")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    public IsoMax5PositiveNumber? WalletAccountAge { get; init; } 
    
    /// <summary>
    /// Number of days since the last activity on the wallet.
    /// </summary>
    [IsoId("_ZWVcIJlaEeu76rs9yGlfEg")]
    [DisplayName("Days Since Last Activity")]
    [IsoXmlTag("DaysSncLastActvty")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    public IsoMax5PositiveNumber? DaysSinceLastActivity { get; init; } 
    
    /// <summary>
    /// Number of transactions on this wallet within an interval.
    /// </summary>
    [IsoId("_fXxaIJlaEeu76rs9yGlfEg")]
    [DisplayName("Activity")]
    [IsoXmlTag("Actvty")]
    [IsoSimpleType(IsoSimpleType.Max10PositiveNumber)]
    public IsoMax10PositiveNumber? Activity { get; init; } 
    
    /// <summary>
    /// Identifies the interval of the activity.
    /// </summary>
    [IsoId("_IjNAsJlbEeu76rs9yGlfEg")]
    [DisplayName("Activity Interval")]
    [IsoXmlTag("ActvtyIntrvl")]
    public Frequency12Code? ActivityInterval { get; init; } 
    
    /// <summary>
    /// Number of days since wallet settings were changed.
    /// </summary>
    [IsoId("_fwDh0JlbEeu76rs9yGlfEg")]
    [DisplayName("Last Wallet Change")]
    [IsoXmlTag("LastWlltChng")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    public IsoMax5PositiveNumber? LastWalletChange { get; init; } 
    
    /// <summary>
    /// Number of cards suspended in the wallet.
    /// </summary>
    [IsoId("_laUV8JlbEeu76rs9yGlfEg")]
    [DisplayName("Suspended Cards")]
    [IsoXmlTag("SspdCrds")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    public IsoMax5PositiveNumber? SuspendedCards { get; init; } 
    
    /// <summary>
    /// Country of the wallet account.
    /// </summary>
    [IsoId("_vOvn8JlcEeu76rs9yGlfEg")]
    [DisplayName("Wallet Account Country")]
    [IsoXmlTag("WlltAcctCtry")]
    public ISOMax3ACountryCode? WalletAccountCountry { get; init; } 
    
    /// <summary>
    /// Method used to capture the card details for the wallet.
    /// </summary>
    [IsoId("_rkwssJlgEeu76rs9yGlfEg")]
    [DisplayName("Card Data Entry Mode")]
    [IsoXmlTag("CardDataNtryMd")]
    public CardDataReading9Code? CardDataEntryMode { get; init; } 
    
    /// <summary>
    /// Other method used to capture the card details.
    /// </summary>
    [IsoId("_1FNIMJlgEeu76rs9yGlfEg")]
    [DisplayName("Other Card Data Entry Mode")]
    [IsoXmlTag("OthrCardDataNtryMd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherCardDataEntryMode { get; init; } 
    
    /// <summary>
    /// Number of days the email address has been in the wallet.
    /// </summary>
    [IsoId("_CoEQQJlhEeu76rs9yGlfEg")]
    [DisplayName("Wallet Account Email Age")]
    [IsoXmlTag("WlltAcctEmailAge")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    public IsoMax5PositiveNumber? WalletAccountEmailAge { get; init; } 
    
    /// <summary>
    /// Wallet Provider Risk Assessment.
    /// </summary>
    [IsoId("_JJjDcJllEeu76rs9yGlfEg")]
    [DisplayName("Wallet Provider Risk Assessment")]
    [IsoXmlTag("WlltPrvdrRskAssmnt")]
    public RiskAssessment1Code? WalletProviderRiskAssessment { get; init; } 
    
    /// <summary>
    /// Wallet Provider Risk Assessment Model Version used to create scores.
    /// </summary>
    [IsoId("_8LKhcJlkEeu76rs9yGlfEg")]
    [DisplayName("Wallet Provider Risk Assessment Model Version")]
    [IsoXmlTag("WlltPrvdrRskAssmntMdlVrsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? WalletProviderRiskAssessmentModelVersion { get; init; } 
    
    /// <summary>
    /// A value to determine trust level of the phone number.
    /// </summary>
    [IsoId("_Wc6-AJllEeu76rs9yGlfEg")]
    [DisplayName("Wallet Provider Phone Score")]
    [IsoXmlTag("WlltPrvdrPhneScore")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    public IsoMax5PositiveNumber? WalletProviderPhoneScore { get; init; } 
    
    /// <summary>
    /// A value to determine trust level of the device.
    /// </summary>
    [IsoId("_hZFJkJllEeu76rs9yGlfEg")]
    [DisplayName("Wallet Provider Device Score")]
    [IsoXmlTag("WlltPrvdrDvcScore")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    public IsoMax5PositiveNumber? WalletProviderDeviceScore { get; init; } 
    
    /// <summary>
    /// A value to determine trust level of the account.
    /// </summary>
    [IsoId("_1w3iEJllEeu76rs9yGlfEg")]
    [DisplayName("Wallet Provider Account Score")]
    [IsoXmlTag("WlltPrvdrAcctScore")]
    [IsoSimpleType(IsoSimpleType.Max5PositiveNumber)]
    public IsoMax5PositiveNumber? WalletProviderAccountScore { get; init; } 
    
    /// <summary>
    /// Additional data associated with wallet.
    /// </summary>
    [IsoId("_jFQqc5lYEeu76rs9yGlfEg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
