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
namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction3Choice
{
    /// <summary>
    /// Reference details on the underlying statement cash entry.
    /// </summary>
    [IsoId("_X0Xj5WXpEeap-P22vGV91g")]
    [DisplayName("Statement Entry")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record StatementEntry : UnderlyingTransaction3Choice_
    #else
    public partial class StatementEntry : UnderlyingTransaction3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Set of elements used to provide information on the original message.
        /// </summary>
        [IsoId("_T9Dpcdp-Ed-ak6NoX_4Aeg_1694597164")]
        [DisplayName("Original Group Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrgnlGrpInf")]
        #endif
        [IsoXmlTag("OrgnlGrpInf")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
        #else
        public OriginalGroupInformation3? OriginalGroupInformation { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
        /// </summary>
        [IsoId("_T9Dpctp-Ed-ak6NoX_4Aeg_1694596697")]
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
        [IsoId("_T9Dpc9p-Ed-ak6NoX_4Aeg_1694596718")]
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
        
        
        #nullable disable
        
    }
}
