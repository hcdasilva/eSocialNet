// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Schemas {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
    public partial class SignatureType {
        
        private SignedInfoType signedInfoField;
        
        private SignatureValueType signatureValueField;
        
        private KeyInfoType keyInfoField;
        
        private string idField;
        
        /// <remarks/>
        public SignedInfoType SignedInfo {
            get {
                return this.signedInfoField;
            }
            set {
                this.signedInfoField = value;
            }
        }
        
        /// <remarks/>
        public SignatureValueType SignatureValue {
            get {
                return this.signatureValueField;
            }
            set {
                this.signatureValueField = value;
            }
        }
        
        /// <remarks/>
        public KeyInfoType KeyInfo {
            get {
                return this.keyInfoField;
            }
            set {
                this.keyInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType {
        
        private SignedInfoTypeCanonicalizationMethod canonicalizationMethodField;
        
        private SignedInfoTypeSignatureMethod signatureMethodField;
        
        private ReferenceType referenceField;
        
        private string idField;
        
        /// <remarks/>
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod {
            get {
                return this.canonicalizationMethodField;
            }
            set {
                this.canonicalizationMethodField = value;
            }
        }
        
        /// <remarks/>
        public SignedInfoTypeSignatureMethod SignatureMethod {
            get {
                return this.signatureMethodField;
            }
            set {
                this.signatureMethodField = value;
            }
        }
        
        /// <remarks/>
        public ReferenceType Reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod {
        
        private string algorithmField;
        
        public SignedInfoTypeCanonicalizationMethod() {
            this.algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class TPeriodoValidade {
        
        private string iniValidField;
        
        private string fimValidField;
        
        /// <remarks/>
        public string iniValid {
            get {
                return this.iniValidField;
            }
            set {
                this.iniValidField = value;
            }
        }
        
        /// <remarks/>
        public string fimValid {
            get {
                return this.fimValidField;
            }
            set {
                this.fimValidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class TDadosAmbiente {
        
        private string dscAmbField;
        
        private sbyte localAmbField;
        
        private sbyte tpInscField;
        
        private string nrInscField;
        
        private TDadosAmbienteFatorRisco[] fatorRiscoField;
        
        /// <remarks/>
        public string dscAmb {
            get {
                return this.dscAmbField;
            }
            set {
                this.dscAmbField = value;
            }
        }
        
        /// <remarks/>
        public sbyte localAmb {
            get {
                return this.localAmbField;
            }
            set {
                this.localAmbField = value;
            }
        }
        
        /// <remarks/>
        public sbyte tpInsc {
            get {
                return this.tpInscField;
            }
            set {
                this.tpInscField = value;
            }
        }
        
        /// <remarks/>
        public string nrInsc {
            get {
                return this.nrInscField;
            }
            set {
                this.nrInscField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fatorRisco")]
        public TDadosAmbienteFatorRisco[] fatorRisco {
            get {
                return this.fatorRiscoField;
            }
            set {
                this.fatorRiscoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class TDadosAmbienteFatorRisco {
        
        private string codFatRisField;
        
        private sbyte utilizEPCField;
        
        /// <remarks/>
        public string codFatRis {
            get {
                return this.codFatRisField;
            }
            set {
                this.codFatRisField = value;
            }
        }
        
        /// <remarks/>
        public sbyte utilizEPC {
            get {
                return this.utilizEPCField;
            }
            set {
                this.utilizEPCField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class TIdeAmbiente {
        
        private string codAmbField;
        
        private string iniValidField;
        
        private string fimValidField;
        
        /// <remarks/>
        public string codAmb {
            get {
                return this.codAmbField;
            }
            set {
                this.codAmbField = value;
            }
        }
        
        /// <remarks/>
        public string iniValid {
            get {
                return this.iniValidField;
            }
            set {
                this.iniValidField = value;
            }
        }
        
        /// <remarks/>
        public string fimValid {
            get {
                return this.fimValidField;
            }
            set {
                this.fimValidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class TEmpregador {
        
        private sbyte tpInscField;
        
        private string nrInscField;
        
        /// <remarks/>
        public sbyte tpInsc {
            get {
                return this.tpInscField;
            }
            set {
                this.tpInscField = value;
            }
        }
        
        /// <remarks/>
        public string nrInsc {
            get {
                return this.nrInscField;
            }
            set {
                this.nrInscField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class TIdeCadastro {
        
        private sbyte tpAmbField;
        
        private sbyte procEmiField;
        
        private string verProcField;
        
        /// <remarks/>
        public sbyte tpAmb {
            get {
                return this.tpAmbField;
            }
            set {
                this.tpAmbField = value;
            }
        }
        
        /// <remarks/>
        public sbyte procEmi {
            get {
                return this.procEmiField;
            }
            set {
                this.procEmiField = value;
            }
        }
        
        /// <remarks/>
        public string verProc {
            get {
                return this.verProcField;
            }
            set {
                this.verProcField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType {
        
        private byte[] x509CertificateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] X509Certificate {
            get {
                return this.x509CertificateField;
            }
            set {
                this.x509CertificateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType {
        
        private X509DataType x509DataField;
        
        private string idField;
        
        /// <remarks/>
        public X509DataType X509Data {
            get {
                return this.x509DataField;
            }
            set {
                this.x509DataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType {
        
        private string idField;
        
        private byte[] valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType {
        
        private string[] xPathField;
        
        private TTransformURI algorithmField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPath")]
        public string[] XPath {
            get {
                return this.xPathField;
            }
            set {
                this.xPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TTransformURI Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType {
        
        private TransformType[] transformsField;
        
        private ReferenceTypeDigestMethod digestMethodField;
        
        private byte[] digestValueField;
        
        private string idField;
        
        private string uRIField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
        public TransformType[] Transforms {
            get {
                return this.transformsField;
            }
            set {
                this.transformsField = value;
            }
        }
        
        /// <remarks/>
        public ReferenceTypeDigestMethod DigestMethod {
            get {
                return this.digestMethodField;
            }
            set {
                this.digestMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] DigestValue {
            get {
                return this.digestValueField;
            }
            set {
                this.digestValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI {
            get {
                return this.uRIField;
            }
            set {
                this.uRIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod {
        
        private string algorithmField;
        
        public ReferenceTypeDigestMethod() {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod {
        
        private string algorithmField;
        
        public SignedInfoTypeSignatureMethod() {
            this.algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm {
            get {
                return this.algorithmField;
            }
            set {
                this.algorithmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00", IsNullable=false)]
    public partial class eSocial {
        
        private eSocialEvtTabAmbiente evtTabAmbienteField;
        
        private SignatureType signatureField;
        
        /// <remarks/>
        public eSocialEvtTabAmbiente evtTabAmbiente {
            get {
                return this.evtTabAmbienteField;
            }
            set {
                this.evtTabAmbienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class eSocialEvtTabAmbiente {
        
        private TIdeCadastro ideEventoField;
        
        private TEmpregador ideEmpregadorField;
        
        private eSocialEvtTabAmbienteInfoAmbiente infoAmbienteField;
        
        private string idField;
        
        /// <remarks/>
        public TIdeCadastro ideEvento {
            get {
                return this.ideEventoField;
            }
            set {
                this.ideEventoField = value;
            }
        }
        
        /// <remarks/>
        public TEmpregador ideEmpregador {
            get {
                return this.ideEmpregadorField;
            }
            set {
                this.ideEmpregadorField = value;
            }
        }
        
        /// <remarks/>
        public eSocialEvtTabAmbienteInfoAmbiente infoAmbiente {
            get {
                return this.infoAmbienteField;
            }
            set {
                this.infoAmbienteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class eSocialEvtTabAmbienteInfoAmbiente {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alteracao", typeof(eSocialEvtTabAmbienteInfoAmbienteAlteracao))]
        [System.Xml.Serialization.XmlElementAttribute("exclusao", typeof(eSocialEvtTabAmbienteInfoAmbienteExclusao))]
        [System.Xml.Serialization.XmlElementAttribute("inclusao", typeof(eSocialEvtTabAmbienteInfoAmbienteInclusao))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class eSocialEvtTabAmbienteInfoAmbienteAlteracao {
        
        private TIdeAmbiente ideAmbienteField;
        
        private TDadosAmbiente dadosAmbienteField;
        
        private TPeriodoValidade novaValidadeField;
        
        /// <remarks/>
        public TIdeAmbiente ideAmbiente {
            get {
                return this.ideAmbienteField;
            }
            set {
                this.ideAmbienteField = value;
            }
        }
        
        /// <remarks/>
        public TDadosAmbiente dadosAmbiente {
            get {
                return this.dadosAmbienteField;
            }
            set {
                this.dadosAmbienteField = value;
            }
        }
        
        /// <remarks/>
        public TPeriodoValidade novaValidade {
            get {
                return this.novaValidadeField;
            }
            set {
                this.novaValidadeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class eSocialEvtTabAmbienteInfoAmbienteExclusao {
        
        private TIdeAmbiente ideAmbienteField;
        
        /// <remarks/>
        public TIdeAmbiente ideAmbiente {
            get {
                return this.ideAmbienteField;
            }
            set {
                this.ideAmbienteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "0.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTabAmbTrabalho/v02_01_00")]
    public partial class eSocialEvtTabAmbienteInfoAmbienteInclusao {
        
        private TIdeAmbiente ideAmbienteField;
        
        private TDadosAmbiente dadosAmbienteField;
        
        /// <remarks/>
        public TIdeAmbiente ideAmbiente {
            get {
                return this.ideAmbienteField;
            }
            set {
                this.ideAmbienteField = value;
            }
        }
        
        /// <remarks/>
        public TDadosAmbiente dadosAmbiente {
            get {
                return this.dadosAmbienteField;
            }
            set {
                this.dadosAmbienteField = value;
            }
        }
    }
}
