// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:3138,x:33238,y:32602,varname:node_3138,prsc:2|normal-4709-OUT,emission-4709-OUT;n:type:ShaderForge.SFN_NormalVector,id:7656,x:31440,y:32712,prsc:2,pt:False;n:type:ShaderForge.SFN_FragmentPosition,id:1152,x:31440,y:32932,varname:node_1152,prsc:2;n:type:ShaderForge.SFN_Normalize,id:5713,x:31678,y:32932,varname:node_5713,prsc:2|IN-1152-Y;n:type:ShaderForge.SFN_Append,id:1948,x:31678,y:33179,varname:node_1948,prsc:2|A-1152-X,B-1152-Z;n:type:ShaderForge.SFN_ComponentMask,id:5542,x:31678,y:32714,varname:node_5542,prsc:2,cc1:0,cc2:1,cc3:2,cc4:-1|IN-7656-OUT;n:type:ShaderForge.SFN_Dot,id:9236,x:31935,y:32819,varname:node_9236,prsc:2,dt:1|A-5542-G,B-5713-OUT;n:type:ShaderForge.SFN_Dot,id:868,x:31935,y:33033,varname:node_868,prsc:2,dt:2|A-5542-G,B-5713-OUT;n:type:ShaderForge.SFN_If,id:8631,x:32115,y:32904,varname:node_8631,prsc:2|A-5713-OUT,B-3940-OUT,GT-9236-OUT,EQ-868-OUT,LT-868-OUT;n:type:ShaderForge.SFN_Vector1,id:3940,x:31935,y:32968,varname:node_3940,prsc:2,v1:0;n:type:ShaderForge.SFN_Append,id:5085,x:32132,y:32733,varname:node_5085,prsc:2|A-5542-R,B-8631-OUT,C-5542-B;n:type:ShaderForge.SFN_Multiply,id:1577,x:32302,y:32733,varname:node_1577,prsc:2|A-5085-OUT,B-5085-OUT;n:type:ShaderForge.SFN_Color,id:2230,x:32302,y:32580,ptovrint:False,ptlb:ColorBase,ptin:_ColorBase,varname:node_2230,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2125748,c2:0.4528302,c3:0.1388395,c4:1;n:type:ShaderForge.SFN_Tex2d,id:230,x:32074,y:33182,ptovrint:False,ptlb:TextureBottom,ptin:_TextureBottom,varname:node_230,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:46671ce9b6548d6418bf2b00bd46cd33,ntxv:2,isnm:False|UVIN-1948-OUT;n:type:ShaderForge.SFN_Add,id:4709,x:32754,y:32580,varname:node_4709,prsc:2|A-2230-RGB,B-823-OUT;n:type:ShaderForge.SFN_ChannelBlend,id:1783,x:32481,y:32875,varname:node_1783,prsc:2,chbt:0|M-1577-OUT,R-6765-OUT,G-9028-OUT,B-6765-OUT;n:type:ShaderForge.SFN_Multiply,id:9028,x:32279,y:33182,varname:node_9028,prsc:2|A-230-RGB,B-5480-OUT;n:type:ShaderForge.SFN_Vector3,id:6765,x:32270,y:32942,varname:node_6765,prsc:2,v1:0,v2:0,v3:0;n:type:ShaderForge.SFN_Step,id:823,x:32795,y:32849,varname:node_823,prsc:2|A-7228-OUT,B-1783-OUT;n:type:ShaderForge.SFN_Slider,id:7228,x:32460,y:33072,ptovrint:False,ptlb:Height,ptin:_Height,varname:node_7228,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:3.678177,max:5;n:type:ShaderForge.SFN_Slider,id:5480,x:31917,y:33361,ptovrint:False,ptlb:ZET DEZE OP 5 ANDERS EXPLODEERT IE,ptin:_ZETDEZEOP5ANDERSEXPLODEERTIE,varname:node_5480,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5,max:5;proporder:2230-230-7228-5480;pass:END;sub:END;*/

Shader "Shader Forge/HeightShader" {
    Properties {
        _ColorBase ("ColorBase", Color) = (0.2125748,0.4528302,0.1388395,1)
        _TextureBottom ("TextureBottom", 2D) = "black" {}
        _Height ("Height", Range(0, 5)) = 3.678177
        _ZETDEZEOP5ANDERSEXPLODEERTIE ("ZET DEZE OP 5 ANDERS EXPLODEERT IE", Range(0, 5)) = 5
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform float4 _ColorBase;
            uniform sampler2D _TextureBottom; uniform float4 _TextureBottom_ST;
            uniform float _Height;
            uniform float _ZETDEZEOP5ANDERSEXPLODEERTIE;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float4 posWorld : TEXCOORD0;
                float3 normalDir : TEXCOORD1;
                float3 tangentDir : TEXCOORD2;
                float3 bitangentDir : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 node_5542 = i.normalDir.rgb;
                float node_5713 = normalize(i.posWorld.g);
                float node_8631_if_leA = step(node_5713,0.0);
                float node_8631_if_leB = step(0.0,node_5713);
                float node_868 = min(0,dot(node_5542.g,node_5713));
                float3 node_5085 = float3(node_5542.r,lerp((node_8631_if_leA*node_868)+(node_8631_if_leB*max(0,dot(node_5542.g,node_5713))),node_868,node_8631_if_leA*node_8631_if_leB),node_5542.b);
                float3 node_1577 = (node_5085*node_5085);
                float3 node_6765 = float3(0,0,0);
                float2 node_1948 = float2(i.posWorld.r,i.posWorld.b);
                float4 _TextureBottom_var = tex2D(_TextureBottom,TRANSFORM_TEX(node_1948, _TextureBottom));
                float3 node_4709 = (_ColorBase.rgb+step(_Height,(node_1577.r*node_6765 + node_1577.g*(_TextureBottom_var.rgb*_ZETDEZEOP5ANDERSEXPLODEERTIE) + node_1577.b*node_6765)));
                float3 normalLocal = node_4709;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
////// Lighting:
////// Emissive:
                float3 emissive = node_4709;
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
