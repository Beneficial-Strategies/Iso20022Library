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
namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData9Choice
{
    /// <summary>
    /// Details of the margin lending transaction.
    /// </summary>
    [IsoId("_pgDKsKoMEemdLtwzt4CWxg")]
    [DisplayName("Margin Lending")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MarginLending : TransactionLoanData9Choice_
    #else
    public partial class MarginLending : TransactionLoanData9Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MarginLending instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MarginLending( System.DateOnly reqEventDate )
        {
            EventDate = reqEventDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_vFPjgaoKEemdLtwzt4CWxg")]
        [DisplayName("Event Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EvtDt")]
        #endif
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate EventDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly EventDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly EventDate { get; init; } 
        #else
        public System.DateOnly EventDate { get; set; } 
        #endif
        
        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_tnAD4aoKEemdLtwzt4CWxg")]
        [DisplayName("Unique Trade Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnqTradIdr")]
        #endif
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? UniqueTradeIdentifier { get; init; } 
        #else
        public System.String? UniqueTradeIdentifier { get; set; } 
        #endif
        
        /// <summary>
        /// Reference to master agreement under which the counterparties concluded a documented transaction.
        /// </summary>
        [IsoId("_tnAD46oKEemdLtwzt4CWxg")]
        [DisplayName("Master Agreement")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MstrAgrmt")]
        #endif
        [IsoXmlTag("MstrAgrmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MasterAgreement6? MasterAgreement { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MasterAgreement6? MasterAgreement { get; init; } 
        #else
        public MasterAgreement6? MasterAgreement { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
