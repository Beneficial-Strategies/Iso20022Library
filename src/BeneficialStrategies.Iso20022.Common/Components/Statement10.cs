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
/// General characteristics related to a statement which reports information for a precise date.
/// </summary>
[IsoId("_Rhyg4Np-Ed-ak6NoX_4Aeg_2060760471")]
[DisplayName("Statement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Statement10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Statement10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Statement10( System.String reqIdentifier,DateAndDateTimeChoice_ reqStatementDateTime,FrequencyCodeAndDSSCode1Choice_ reqFrequency,StatementUpdateTypeCodeAndDSSCodeChoice_ reqUpdateType,System.String reqActivityIndicator,StatementBasisCodeAndDSSCodeChoice_ reqStatementBasis )
    {
        Identifier = reqIdentifier;
        StatementDateTime = reqStatementDateTime;
        Frequency = reqFrequency;
        UpdateType = reqUpdateType;
        ActivityIndicator = reqActivityIndicator;
        StatementBasis = reqStatementBasis;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference of the statement.
    /// </summary>
    [IsoId("_Rhyg4dp-Ed-ak6NoX_4Aeg_2060760502")]
    [DisplayName("Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Idr")]
    #endif
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identifier { get; init; } 
    #else
    public System.String Identifier { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_Rhyg4tp-Ed-ak6NoX_4Aeg_2060760533")]
    [DisplayName("Statement Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtDtTm")]
    #endif
    [IsoXmlTag("StmtDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_ StatementDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_ StatementDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency of the statement.
    /// </summary>
    [IsoId("_Rhyg49p-Ed-ak6NoX_4Aeg_2060760648")]
    [DisplayName("Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Frqcy")]
    #endif
    [IsoXmlTag("Frqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FrequencyCodeAndDSSCode1Choice_ Frequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FrequencyCodeAndDSSCode1Choice_ Frequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FrequencyCodeAndDSSCode1Choice_ Frequency { get; init; } 
    #else
    public FrequencyCodeAndDSSCode1Choice_ Frequency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the report is complete or contains changes only.
    /// </summary>
    [IsoId("_Rhyg5Np-Ed-ak6NoX_4Aeg_2060760679")]
    [DisplayName("Update Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdTp")]
    #endif
    [IsoXmlTag("UpdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatementUpdateTypeCodeAndDSSCodeChoice_ UpdateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatementUpdateTypeCodeAndDSSCodeChoice_ UpdateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementUpdateTypeCodeAndDSSCodeChoice_ UpdateType { get; init; } 
    #else
    public StatementUpdateTypeCodeAndDSSCodeChoice_ UpdateType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    [IsoId("_Rhyg5dp-Ed-ak6NoX_4Aeg_2060760957")]
    [DisplayName("Activity Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtyInd")]
    #endif
    [IsoXmlTag("ActvtyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ActivityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ActivityIndicator { get; init; } 
    #else
    public System.String ActivityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of balance on which the statement is prepared.
    /// </summary>
    [IsoId("_Rhyg5tp-Ed-ak6NoX_4Aeg_2060760988")]
    [DisplayName("Statement Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtBsis")]
    #endif
    [IsoXmlTag("StmtBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatementBasisCodeAndDSSCodeChoice_ StatementBasis { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatementBasisCodeAndDSSCodeChoice_ StatementBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementBasisCodeAndDSSCodeChoice_ StatementBasis { get; init; } 
    #else
    public StatementBasisCodeAndDSSCodeChoice_ StatementBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Sequential number of the statement.
    /// </summary>
    [IsoId("_Rhyg59p-Ed-ak6NoX_4Aeg_2060761018")]
    [DisplayName("Report Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptNb")]
    #endif
    [IsoXmlTag("RptNb")]
    [IsoSimpleType(IsoSimpleType.Max5NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? ReportNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportNumber { get; init; } 
    #else
    public System.String? ReportNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
