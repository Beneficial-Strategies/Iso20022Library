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
/// Specifies the details relative to the submission of the insurance data set.
/// </summary>
[IsoId("_Rax58tp-Ed-ak6NoX_4Aeg_-1897093654")]
[DisplayName("Required Submission")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RequiredSubmission3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RequiredSubmission3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RequiredSubmission3( System.String reqMatchIssueDate,System.String reqMatchTransport,System.String reqMatchAmount )
    {
        MatchIssueDate = reqMatchIssueDate;
        MatchTransport = reqMatchTransport;
        MatchAmount = reqMatchAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    [IsoId("_Rax589p-Ed-ak6NoX_4Aeg_-1897093637")]
    [DisplayName("Submitter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Submitr")]
    #endif
    [IsoXmlTag("Submitr")]
    public ValueList<BICIdentification1> Submitter { get; init; } = new ValueList<BICIdentification1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Rax589p-Ed-ak6NoX_4Aeg_-1897093637
    
    /// <summary>
    /// Specifies if the issuer must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_Rax59Np-Ed-ak6NoX_4Aeg_1704101757")]
    [DisplayName("Match Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchIssr")]
    #endif
    [IsoXmlTag("MtchIssr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification27? MatchIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification27? MatchIssuer { get; init; } 
    #else
    public PartyIdentification27? MatchIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the issue date must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_Rax59dp-Ed-ak6NoX_4Aeg_-1540614996")]
    [DisplayName("Match Issue Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchIsseDt")]
    #endif
    [IsoXmlTag("MtchIsseDt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MatchIssueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MatchIssueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MatchIssueDate { get; init; } 
    #else
    public System.String MatchIssueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the transport information must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_Rax59tp-Ed-ak6NoX_4Aeg_-1514758562")]
    [DisplayName("Match Transport")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchTrnsprt")]
    #endif
    [IsoXmlTag("MtchTrnsprt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MatchTransport { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MatchTransport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MatchTransport { get; init; } 
    #else
    public System.String MatchTransport { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the insured amount must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_Rax599p-Ed-ak6NoX_4Aeg_-1037296621")]
    [DisplayName("Match Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchAmt")]
    #endif
    [IsoXmlTag("MtchAmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator MatchAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MatchAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MatchAmount { get; init; } 
    #else
    public System.String MatchAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies which clauses are required in the insurance data set.
    /// </summary>
    [IsoId("_Rax5-Np-Ed-ak6NoX_4Aeg_-1000355227")]
    [DisplayName("Clauses Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClausesReqrd")]
    #endif
    [IsoXmlTag("ClausesReqrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InsuranceClauses1Code? ClausesRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InsuranceClauses1Code? ClausesRequired { get; init; } 
    #else
    public InsuranceClauses1Code? ClausesRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the assured (insured) party must be matched as part of the validation of the data set.
    /// </summary>
    [IsoId("_Ra7q8Np-Ed-ak6NoX_4Aeg_-711292782")]
    [DisplayName("Match Assured Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchAssrdPty")]
    #endif
    [IsoXmlTag("MtchAssrdPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssuredType1Code? MatchAssuredParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssuredType1Code? MatchAssuredParty { get; init; } 
    #else
    public AssuredType1Code? MatchAssuredParty { get; set; } 
    #endif
    
    
    #nullable disable
    
}
