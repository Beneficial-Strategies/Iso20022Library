// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.055.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CCPMemberRequirementsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the collateral requirements that a central counterparty obligates a clearing member post at the central counterparty.
/// </summary>
[Description(@"The CCPMemberRequirementsReport message is sent from the central counterparty to the national competent authority. It is used to inform the national competent authority about the collateral requirements that a central counterparty obligates a clearing member post at the central counterparty.")]
[IsoId("_daMXQeUUEem3X-64-NKdqg")]
[DisplayName("CCP Member Requirements Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CCPMemberRequirementsReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.055.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CCPMmbRqrmntsRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.055.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CCPMemberRequirementsReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CCPMemberRequirementsReportV01( IntraDayRequirement1 reqIntraDayRequirementAmount,EndOfDayRequirement2 reqEndOfDayRequirement,DefaultFundRequirement1 reqDefaultFundRequirement )
    {
        IntraDayRequirementAmount = reqIntraDayRequirementAmount;
        EndOfDayRequirement = reqEndOfDayRequirement;
        DefaultFundRequirement = reqDefaultFundRequirement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Obligations of a clearing member with respect to a central counterparty that are calculated based on intraday positions.
    /// </summary>
    [IsoId("_daMXSeUUEem3X-64-NKdqg")]
    [DisplayName("Intra Day Requirement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraDayRqrmntAmt")]
    #endif
    [IsoXmlTag("IntraDayRqrmntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IntraDayRequirement1 IntraDayRequirementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IntraDayRequirement1 IntraDayRequirementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntraDayRequirement1 IntraDayRequirementAmount { get; init; } 
    #else
    public IntraDayRequirement1 IntraDayRequirementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Describes an instance of an intraday margin call being made against a margin account.
    /// </summary>
    [IsoId("_daMXS-UUEem3X-64-NKdqg")]
    [DisplayName("Intra Day Margin Call")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraDayMrgnCall")]
    #endif
    [IsoXmlTag("IntraDayMrgnCall")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IntraDayMarginCall1? IntraDayMarginCall { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntraDayMarginCall1? IntraDayMarginCall { get; init; } 
    #else
    public IntraDayMarginCall1? IntraDayMarginCall { get; set; } 
    #endif
    
    /// <summary>
    /// Obligations of a clearing member with respect to a central counterparty that are calculated based on end of day positions.
    /// </summary>
    [IsoId("_daMXTeUUEem3X-64-NKdqg")]
    [DisplayName("End Of Day Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndOfDayRqrmnt")]
    #endif
    [IsoXmlTag("EndOfDayRqrmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EndOfDayRequirement2 EndOfDayRequirement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EndOfDayRequirement2 EndOfDayRequirement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EndOfDayRequirement2 EndOfDayRequirement { get; init; } 
    #else
    public EndOfDayRequirement2 EndOfDayRequirement { get; set; } 
    #endif
    
    /// <summary>
    /// Requirement for a clearing member to post collateral at a central counterparty with respect to a default fund.
    /// </summary>
    [IsoId("_daMXT-UUEem3X-64-NKdqg")]
    [DisplayName("Default Fund Requirement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltFndRqrmnt")]
    #endif
    [IsoXmlTag("DfltFndRqrmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DefaultFundRequirement1 DefaultFundRequirement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DefaultFundRequirement1 DefaultFundRequirement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DefaultFundRequirement1 DefaultFundRequirement { get; init; } 
    #else
    public DefaultFundRequirement1 DefaultFundRequirement { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_daMXUeUUEem3X-64-NKdqg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CCPMemberRequirementsReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CCPMemberRequirementsReportV01.

