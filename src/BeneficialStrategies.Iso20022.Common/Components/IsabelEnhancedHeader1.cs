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
/// Specifies the enhanced parameters for an Isabel payment file.
/// </summary>
[IsoId("_wsbQIMmJEeWAGphE2LvqeA")]
[DisplayName("Isabel Enhanced Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IsabelEnhancedHeader1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IsabelEnhancedHeader1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IsabelEnhancedHeader1( DebitType1Code reqDebitType,DebitType1Code reqBankDebitType,System.String reqAccountBasedContract,Validation1Code reqValidationResults,Validation2Code reqPowerToSignValidationResults,System.DateTime reqPowerToSignValidationTimeStamp,IsabelSenderTrigger1Choice_ reqSenderTrigger,System.DateTime reqSendTimeStamp,System.String reqExtraConditionsAccepted,IsabelInputSource1Choice_ reqSource )
    {
        DebitType = reqDebitType;
        BankDebitType = reqBankDebitType;
        AccountBasedContract = reqAccountBasedContract;
        ValidationResults = reqValidationResults;
        PowerToSignValidationResults = reqPowerToSignValidationResults;
        PowerToSignValidationTimeStamp = reqPowerToSignValidationTimeStamp;
        SenderTrigger = reqSenderTrigger;
        SendTimeStamp = reqSendTimeStamp;
        ExtraConditionsAccepted = reqExtraConditionsAccepted;
        Source = reqSource;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of debit to be applied to the payment, as provided by the end-user.
    /// </summary>
    [IsoId("_FdV6UMmKEeWAGphE2LvqeA")]
    [DisplayName("Debit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DbtTp")]
    #endif
    [IsoXmlTag("DbtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DebitType1Code DebitType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DebitType1Code DebitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebitType1Code DebitType { get; init; } 
    #else
    public DebitType1Code DebitType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of debit to be applied to the payment, as provided by the bank.
    /// This may supersede the debit type provided by the end-user.
    /// </summary>
    [IsoId("_aW14wcmKEeWAGphE2LvqeA")]
    [DisplayName("Bank Debit Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BkDbtTp")]
    #endif
    [IsoXmlTag("BkDbtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DebitType1Code BankDebitType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DebitType1Code BankDebitType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DebitType1Code BankDebitType { get; init; } 
    #else
    public DebitType1Code BankDebitType { get; set; } 
    #endif
    
    /// <summary>
    /// Contract is defined on a specific account.
    /// </summary>
    [IsoId("_jZtncMmKEeWAGphE2LvqeA")]
    [DisplayName("Account Based Contract")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBasedCtrct")]
    #endif
    [IsoXmlTag("AcctBasedCtrct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator AccountBasedContract { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AccountBasedContract { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AccountBasedContract { get; init; } 
    #else
    public System.String AccountBasedContract { get; set; } 
    #endif
    
    /// <summary>
    /// Results of all validations performed during the processing of a file provided in the payload.
    /// </summary>
    [IsoId("_qAcD0MmKEeWAGphE2LvqeA")]
    [DisplayName("Validation Results")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtnRslts")]
    #endif
    [IsoXmlTag("VldtnRslts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Validation1Code ValidationResults { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Validation1Code ValidationResults { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Validation1Code ValidationResults { get; init; } 
    #else
    public Validation1Code ValidationResults { get; set; } 
    #endif
    
    /// <summary>
    /// Results of the signature validation provided by the &apos;PowerToSign&apos; user.
    /// </summary>
    [IsoId("_FDlhEMmLEeWAGphE2LvqeA")]
    [DisplayName("Power To Sign Validation Results")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrToSgnVldtnRslts")]
    #endif
    [IsoXmlTag("PwrToSgnVldtnRslts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Validation2Code PowerToSignValidationResults { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Validation2Code PowerToSignValidationResults { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Validation2Code PowerToSignValidationResults { get; init; } 
    #else
    public Validation2Code PowerToSignValidationResults { get; set; } 
    #endif
    
    /// <summary>
    /// Validation of the time stamp provided by the &apos;PowerToSign&apos; user.
    /// </summary>
    [IsoId("_LmXRkcmLEeWAGphE2LvqeA")]
    [DisplayName("Power To Sign Validation Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrToSgnVldtnTmStmp")]
    #endif
    [IsoXmlTag("PwrToSgnVldtnTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime PowerToSignValidationTimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime PowerToSignValidationTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime PowerToSignValidationTimeStamp { get; init; } 
    #else
    public System.DateTime PowerToSignValidationTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Trigger used by the sender to transfer the file.
    /// </summary>
    [IsoId("_W6QnsMmLEeWAGphE2LvqeA")]
    [DisplayName("Sender Trigger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrTrggr")]
    #endif
    [IsoXmlTag("SndrTrggr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsabelSenderTrigger1Choice_ SenderTrigger { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IsabelSenderTrigger1Choice_ SenderTrigger { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IsabelSenderTrigger1Choice_ SenderTrigger { get; init; } 
    #else
    public IsabelSenderTrigger1Choice_ SenderTrigger { get; set; } 
    #endif
    
    /// <summary>
    /// Time stamp on when the file is sent.
    /// </summary>
    [IsoId("_AzCccMmMEeWAGphE2LvqeA")]
    [DisplayName("Send Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndTmStmp")]
    #endif
    [IsoXmlTag("SndTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime SendTimeStamp { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime SendTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime SendTimeStamp { get; init; } 
    #else
    public System.DateTime SendTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether extra conditions are applicable and accepted for this file.
    /// </summary>
    [IsoId("_G6yd0MmMEeWAGphE2LvqeA")]
    [DisplayName("Extra Conditions Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtraCondsAccptd")]
    #endif
    [IsoXmlTag("XtraCondsAccptd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator ExtraConditionsAccepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtraConditionsAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtraConditionsAccepted { get; init; } 
    #else
    public System.String ExtraConditionsAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Input source for the generation of the file.
    /// </summary>
    [IsoId("_M49scMmMEeWAGphE2LvqeA")]
    [DisplayName("Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Src")]
    #endif
    [IsoXmlTag("Src")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsabelInputSource1Choice_ Source { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IsabelInputSource1Choice_ Source { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IsabelInputSource1Choice_ Source { get; init; } 
    #else
    public IsabelInputSource1Choice_ Source { get; set; } 
    #endif
    
    /// <summary>
    /// Number of signatures required to validate the payments file.
    /// </summary>
    [IsoId("_QCi3EMmNEeWAGphE2LvqeA")]
    [DisplayName("Number Of Required Signatures")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfReqrdSgntrs")]
    #endif
    [IsoXmlTag("NbOfReqrdSgntrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? NumberOfRequiredSignatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfRequiredSignatures { get; init; } 
    #else
    public System.UInt64? NumberOfRequiredSignatures { get; set; } 
    #endif
    
    /// <summary>
    /// Extended parameters for an Isabel payment initiation file.
    /// </summary>
    [IsoId("_VcsLkMmNEeWAGphE2LvqeA")]
    [DisplayName("Extended")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnded")]
    #endif
    [IsoXmlTag("Xtnded")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsabelExtendedHeader1? Extended { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IsabelExtendedHeader1? Extended { get; init; } 
    #else
    public IsabelExtendedHeader1? Extended { get; set; } 
    #endif
    
    
    #nullable disable
    
}
