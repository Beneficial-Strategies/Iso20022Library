// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingData1Choice
{
    /// <summary>
    /// Reference details on the underlying statement cash entry.
    /// </summary>
    [IsoId("_CXmpaFRtEe23M4WgERMsYw")]
    [DisplayName("Statement Entry")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record StatementEntry : UnderlyingData1Choice_
    #else
    public partial class StatementEntry : UnderlyingData1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides details of the account, for which the original statement was generated.
        /// </summary>
        [IsoId("_CXmpYFRtEe23M4WgERMsYw")]
        [DisplayName("Original Account")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlAcct")]
        #endif
        [IsoXmlTag("OrgnlAcct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount40? OriginalAccount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount40? OriginalAccount { get; init; } 
        #else
        public CashAccount40? OriginalAccount { get; set; } 
        #endif
        
        /// <summary>
        /// Provides information on the original message.
        /// </summary>
        [IsoId("_CXmpYVRtEe23M4WgERMsYw")]
        [DisplayName("Original Group Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlGrpInf")]
        #endif
        [IsoXmlTag("OrgnlGrpInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
        #else
        public OriginalGroupInformation29? OriginalGroupInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
        /// </summary>
        [IsoId("_CXmpYlRtEe23M4WgERMsYw")]
        [DisplayName("Original Statement Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlStmtId")]
        #endif
        [IsoXmlTag("OrgnlStmtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? OriginalStatementIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? OriginalStatementIdentification { get; init; } 
        #else
        public System.String? OriginalStatementIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Original unique identification, as assigned by the account servicer, to unambiguously identify the original entry.
        /// </summary>
        [IsoId("_CXmpY1RtEe23M4WgERMsYw")]
        [DisplayName("Original Entry Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlNtryId")]
        #endif
        [IsoXmlTag("OrgnlNtryId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? OriginalEntryIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? OriginalEntryIdentification { get; init; } 
        #else
        public System.String? OriginalEntryIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
        /// </summary>
        [IsoId("_CXmpZFRtEe23M4WgERMsYw")]
        [DisplayName("Original UETR")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlUETR")]
        #endif
        [IsoXmlTag("OrgnlUETR")]
        [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoUUIDv4Identifier? OriginalUETR { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? OriginalUETR { get; init; } 
        #else
        public System.String? OriginalUETR { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
