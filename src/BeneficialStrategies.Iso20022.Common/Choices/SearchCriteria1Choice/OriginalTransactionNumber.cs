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
namespace BeneficialStrategies.Iso20022.Choices.SearchCriteria1Choice
{
    /// <summary>
    /// Specifies the original transaction number.
    /// </summary>
    [IsoId("_PWk1NmHcEeGrBqfAqyy96Q")]
    [DisplayName("Original Transaction Number")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OriginalTransactionNumber : SearchCriteria1Choice_
    #else
    public partial class OriginalTransactionNumber : SearchCriteria1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OriginalTransactionNumber instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OriginalTransactionNumber( System.String reqNumber )
        {
            Number = reqNumber;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Idetifies the transaction number.
        /// </summary>
        [IsoId("_py93vGHgEeGrBqfAqyy96Q")]
        [DisplayName("Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nb")]
        #endif
        [IsoXmlTag("Nb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Number { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Number { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Number { get; init; } 
        #else
        public System.String Number { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the type of information request related to an original transaction number as a code.
        /// </summary>
        [IsoId("_wc1usWHgEeGrBqfAqyy96Q")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        public SimpleValueList<TransactionRequestType1Code> Type { get; init; } = new SimpleValueList<TransactionRequestType1Code>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _wc1usWHgEeGrBqfAqyy96Q
        
        /// <summary>
        /// Additional information, in free text form, to complement the requested information.
        /// </summary>
        [IsoId("_yowzsWHgEeGrBqfAqyy96Q")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max500Text)]
        [StringLength(maximumLength: 500 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax500Text? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalInformation { get; init; } 
        #else
        public System.String? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
