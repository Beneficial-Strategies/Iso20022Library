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


namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.016.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends an IntraPositionMovementPostingReport to an account owner to provide the details of increases and decreases in securities with a given status within a holding, that is, intra-position transfers, which occurred during a specified period, for all or selected securities in a specified safekeeping account which the account servicer holds for the account owner. 
/// 
/// |The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or 
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage|:
/// The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information |using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An account servicer sends an IntraPositionMovementPostingReport to an account owner to provide the details of increases and decreases in securities with a given status within a holding, that is, intra-position transfers, which occurred during a specified period, for all or selected securities in a specified safekeeping account which the account servicer holds for the account owner. |||The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|:|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information |using the relevant elements in the Business Application Header.")]
[IsoId("_Qkg2MW6VEeat2-NFbXd1Pw")]
[DisplayName("Intra Position Movement Posting Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IntraPositionMovementPostingReportV06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.016.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraPosMvmntPstngRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.016.001.06";
    
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
    /// Constructs a IntraPositionMovementPostingReportV06 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IntraPositionMovementPostingReportV06( Pagination reqPagination,Statement43 reqStatementGeneralDetails,SecuritiesAccount24 reqSafekeepingAccount )
    {
        Pagination = reqPagination;
        StatementGeneralDetails = reqStatementGeneralDetails;
        SafekeepingAccount = reqSafekeepingAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_Qkg2M26VEeat2-NFbXd1Pw")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination Pagination { get; init; } 
    #else
    public Pagination Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to report.
    /// </summary>
    [IsoId("_Qkg2NW6VEeat2-NFbXd1Pw")]
    [DisplayName("Statement General Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StmtGnlDtls")]
    #endif
    [IsoXmlTag("StmtGnlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Statement43 StatementGeneralDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Statement43 StatementGeneralDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Statement43 StatementGeneralDetails { get; init; } 
    #else
    public Statement43 StatementGeneralDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Qkg2N26VEeat2-NFbXd1Pw")]
    [DisplayName("Account Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctOwnr")]
    #endif
    [IsoXmlTag("AcctOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification92Choice_? AccountOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification92Choice_? AccountOwner { get; init; } 
    #else
    public PartyIdentification92Choice_? AccountOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Qkg2OW6VEeat2-NFbXd1Pw")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount24 SafekeepingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount24 SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount24 SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount24 SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    [IsoId("_Qkg2O26VEeat2-NFbXd1Pw")]
    [DisplayName("Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrm")]
    #endif
    [IsoXmlTag("FinInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentDetails24? FinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentDetails24? FinancialInstrument { get; init; } 
    #else
    public FinancialInstrumentDetails24? FinancialInstrument { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since IntraPositionMovementPostingReportV06Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IntraPositionMovementPostingReportV06.

