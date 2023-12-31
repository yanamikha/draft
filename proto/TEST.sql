PGDMP         -                x           TEST    10.11    10.11 <    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            �           1262    73338    TEST    DATABASE     �   CREATE DATABASE "TEST" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Russian_Russia.1251' LC_CTYPE = 'Russian_Russia.1251';
    DROP DATABASE "TEST";
             postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
             postgres    false            �           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                  postgres    false    4                        3079    12924    plpgsql 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;
    DROP EXTENSION plpgsql;
                  false            �           0    0    EXTENSION plpgsql    COMMENT     @   COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';
                       false    1                        3079    73339 	   uuid-ossp 	   EXTENSION     ?   CREATE EXTENSION IF NOT EXISTS "uuid-ossp" WITH SCHEMA public;
    DROP EXTENSION "uuid-ossp";
                  false    4            �           0    0    EXTENSION "uuid-ossp"    COMMENT     W   COMMENT ON EXTENSION "uuid-ossp" IS 'generate universally unique identifiers (UUIDs)';
                       false    2            �            1259    73350    Areas    TABLE     �   CREATE TABLE public."Areas" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    city_id uuid NOT NULL,
    gcode text NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."Areas";
       public         postgres    false    2    4    4            �            1259    73358    CarStatusHistories    TABLE     2  CREATE TABLE public."CarStatusHistories" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    changedate timestamp without time zone DEFAULT CURRENT_TIMESTAMP NOT NULL,
    car_id uuid NOT NULL,
    carstatus_id uuid NOT NULL,
    dep_id uuid NOT NULL,
    active boolean DEFAULT true NOT NULL
);
 (   DROP TABLE public."CarStatusHistories";
       public         postgres    false    2    4    4            �            1259    73364    CarStatuses    TABLE     �   CREATE TABLE public."CarStatuses" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
 !   DROP TABLE public."CarStatuses";
       public         postgres    false    2    4    4            �            1259    73372    CarTypes    TABLE     �   CREATE TABLE public."CarTypes" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    description text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."CarTypes";
       public         postgres    false    2    4    4            �            1259    73380    Cars    TABLE     A  CREATE TABLE public."Cars" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    cartype_id uuid NOT NULL,
    name text NOT NULL,
    regnumber text NOT NULL,
    brand text NOT NULL,
    leader uuid NOT NULL,
    carstatus_id uuid NOT NULL,
    dep_id uuid NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."Cars";
       public         postgres    false    2    4    4            �            1259    73388    Cities    TABLE       CREATE TABLE public."Cities" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    region_id uuid NOT NULL,
    district_id uuid,
    gcode text NOT NULL,
    citytype_id uuid NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."Cities";
       public         postgres    false    2    4    4            �            1259    73396 	   CityTypes    TABLE     �   CREATE TABLE public."CityTypes" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    shortname text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."CityTypes";
       public         postgres    false    2    4    4            �            1259    73404    DepartAreas    TABLE     �   CREATE TABLE public."DepartAreas" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    city_id uuid NOT NULL,
    area_id uuid,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
 !   DROP TABLE public."DepartAreas";
       public         postgres    false    2    4    4            �            1259    73412    Deps    TABLE     �   CREATE TABLE public."Deps" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    parentid uuid,
    city_id uuid NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."Deps";
       public         postgres    false    2    4    4            �            1259    73420 	   Districts    TABLE     �   CREATE TABLE public."Districts" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    region_id uuid NOT NULL,
    gcode text NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."Districts";
       public         postgres    false    2    4    4            �            1259    73428    PermissionGroups    TABLE     �   CREATE TABLE public."PermissionGroups" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
 &   DROP TABLE public."PermissionGroups";
       public         postgres    false    2    4    4            �            1259    73436    Permissions    TABLE     �   CREATE TABLE public."Permissions" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    permissiongroup_id uuid NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
 !   DROP TABLE public."Permissions";
       public         postgres    false    2    4    4            �            1259    73444    PlaceSubTypes    TABLE     �   CREATE TABLE public."PlaceSubTypes" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    placetype_id uuid NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
 #   DROP TABLE public."PlaceSubTypes";
       public         postgres    false    2    4    4            �            1259    73452 
   PlaceTypes    TABLE     �   CREATE TABLE public."PlaceTypes" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
     DROP TABLE public."PlaceTypes";
       public         postgres    false    2    4    4            �            1259    73460    Places    TABLE     �   CREATE TABLE public."Places" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."Places";
       public         postgres    false    2    4    4            �            1259    73468 	   Positions    TABLE     �   CREATE TABLE public."Positions" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."Positions";
       public         postgres    false    2    4    4            �            1259    73476    QualificationTypes    TABLE     �   CREATE TABLE public."QualificationTypes" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    shortname text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
 (   DROP TABLE public."QualificationTypes";
       public         postgres    false    2    4    4            �            1259    73484    RegionTypes    TABLE     �   CREATE TABLE public."RegionTypes" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    shortname text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
 !   DROP TABLE public."RegionTypes";
       public         postgres    false    2    4    4            �            1259    73492    Regions    TABLE       CREATE TABLE public."Regions" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    gcode text NOT NULL,
    regiontype_id uuid NOT NULL,
    name text NOT NULL,
    mis_id text NOT NULL,
    ismain boolean DEFAULT false NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."Regions";
       public         postgres    false    2    4    4            �            1259    73501    SexTypes    TABLE     �   CREATE TABLE public."SexTypes" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    shortname text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."SexTypes";
       public         postgres    false    2    4    4            �            1259    73509    StreetTypes    TABLE     �   CREATE TABLE public."StreetTypes" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    shortname text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
 !   DROP TABLE public."StreetTypes";
       public         postgres    false    2    4    4            �            1259    73517    Streets    TABLE     +  CREATE TABLE public."Streets" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    district_id uuid,
    city_id uuid NOT NULL,
    area_id uuid,
    gcode text NOT NULL,
    streettype_id uuid NOT NULL,
    name text NOT NULL,
    oldname text,
    active boolean DEFAULT true NOT NULL
);
    DROP TABLE public."Streets";
       public         postgres    false    2    4    4            �            1259    73525    UserGroupPermissions    TABLE     �   CREATE TABLE public."UserGroupPermissions" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    usergroup_id uuid NOT NULL,
    permission_id uuid NOT NULL,
    active boolean DEFAULT true NOT NULL
);
 *   DROP TABLE public."UserGroupPermissions";
       public         postgres    false    2    4    4            �            1259    73530 
   UserGroups    TABLE     �   CREATE TABLE public."UserGroups" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    name text NOT NULL,
    active boolean DEFAULT true NOT NULL
);
     DROP TABLE public."UserGroups";
       public         postgres    false    2    4    4            �            1259    73538    Users    TABLE     �  CREATE TABLE public."Users" (
    id uuid DEFAULT public.uuid_generate_v4() NOT NULL,
    login text NOT NULL,
    password text NOT NULL,
    usergroup_id uuid NOT NULL,
    first_name text NOT NULL,
    last_name text NOT NULL,
    middle_name text NOT NULL,
    position_id uuid NOT NULL,
    birthday date NOT NULL,
    sextype_id uuid NOT NULL,
    work_phone_number text,
    personal_phone_number text,
    qualificationtype_id uuid NOT NULL,
    experience_total smallint,
    experience_field smallint,
    ipn text,
    passport text,
    sertificate text,
    last_qualification_date date,
    workload real,
    comment text,
    active boolean DEFAULT true NOT NULL,
    short_fio text NOT NULL
);
    DROP TABLE public."Users";
       public         postgres    false    2    4    4            �          0    73350    Areas 
   TABLE DATA               C   COPY public."Areas" (id, city_id, gcode, name, active) FROM stdin;
    public       postgres    false    197   �D       �          0    73358    CarStatusHistories 
   TABLE DATA               d   COPY public."CarStatusHistories" (id, changedate, car_id, carstatus_id, dep_id, active) FROM stdin;
    public       postgres    false    198   �D       �          0    73364    CarStatuses 
   TABLE DATA               9   COPY public."CarStatuses" (id, name, active) FROM stdin;
    public       postgres    false    199   	E       �          0    73372    CarTypes 
   TABLE DATA               C   COPY public."CarTypes" (id, name, description, active) FROM stdin;
    public       postgres    false    200   &E       �          0    73380    Cars 
   TABLE DATA               n   COPY public."Cars" (id, cartype_id, name, regnumber, brand, leader, carstatus_id, dep_id, active) FROM stdin;
    public       postgres    false    201   CE       �          0    73388    Cities 
   TABLE DATA               `   COPY public."Cities" (id, region_id, district_id, gcode, citytype_id, name, active) FROM stdin;
    public       postgres    false    202   `E       �          0    73396 	   CityTypes 
   TABLE DATA               B   COPY public."CityTypes" (id, name, shortname, active) FROM stdin;
    public       postgres    false    203   }E       �          0    73404    DepartAreas 
   TABLE DATA               K   COPY public."DepartAreas" (id, city_id, area_id, name, active) FROM stdin;
    public       postgres    false    204   �E       �          0    73412    Deps 
   TABLE DATA               E   COPY public."Deps" (id, name, parentid, city_id, active) FROM stdin;
    public       postgres    false    205   �E       �          0    73420 	   Districts 
   TABLE DATA               I   COPY public."Districts" (id, region_id, gcode, name, active) FROM stdin;
    public       postgres    false    206   �E       �          0    73428    PermissionGroups 
   TABLE DATA               >   COPY public."PermissionGroups" (id, name, active) FROM stdin;
    public       postgres    false    207   �E       �          0    73436    Permissions 
   TABLE DATA               M   COPY public."Permissions" (id, permissiongroup_id, name, active) FROM stdin;
    public       postgres    false    208   �F       �          0    73444    PlaceSubTypes 
   TABLE DATA               I   COPY public."PlaceSubTypes" (id, placetype_id, name, active) FROM stdin;
    public       postgres    false    209   PJ       �          0    73452 
   PlaceTypes 
   TABLE DATA               8   COPY public."PlaceTypes" (id, name, active) FROM stdin;
    public       postgres    false    210   mJ       �          0    73460    Places 
   TABLE DATA               4   COPY public."Places" (id, name, active) FROM stdin;
    public       postgres    false    211   �J       �          0    73468 	   Positions 
   TABLE DATA               7   COPY public."Positions" (id, name, active) FROM stdin;
    public       postgres    false    212   �J       �          0    73476    QualificationTypes 
   TABLE DATA               K   COPY public."QualificationTypes" (id, name, shortname, active) FROM stdin;
    public       postgres    false    213   L       �          0    73484    RegionTypes 
   TABLE DATA               D   COPY public."RegionTypes" (id, name, shortname, active) FROM stdin;
    public       postgres    false    214   L       �          0    73492    Regions 
   TABLE DATA               [   COPY public."Regions" (id, gcode, regiontype_id, name, mis_id, ismain, active) FROM stdin;
    public       postgres    false    215   ;L       �          0    73501    SexTypes 
   TABLE DATA               A   COPY public."SexTypes" (id, name, shortname, active) FROM stdin;
    public       postgres    false    216   XL       �          0    73509    StreetTypes 
   TABLE DATA               D   COPY public."StreetTypes" (id, name, shortname, active) FROM stdin;
    public       postgres    false    217   uL       �          0    73517    Streets 
   TABLE DATA               s   COPY public."Streets" (id, district_id, city_id, area_id, gcode, streettype_id, name, oldname, active) FROM stdin;
    public       postgres    false    218   �L       �          0    73525    UserGroupPermissions 
   TABLE DATA               Y   COPY public."UserGroupPermissions" (id, usergroup_id, permission_id, active) FROM stdin;
    public       postgres    false    219   �L       �          0    73530 
   UserGroups 
   TABLE DATA               8   COPY public."UserGroups" (id, name, active) FROM stdin;
    public       postgres    false    220   �L       �          0    73538    Users 
   TABLE DATA               J  COPY public."Users" (id, login, password, usergroup_id, first_name, last_name, middle_name, position_id, birthday, sextype_id, work_phone_number, personal_phone_number, qualificationtype_id, experience_total, experience_field, ipn, passport, sertificate, last_qualification_date, workload, comment, active, short_fio) FROM stdin;
    public       postgres    false    221   �L       �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �   �   x�U�MN�0�u{�8q��lg$رqbG�̨�Yp{Z��ٿO~~Ś�	��@H
��C)��T�i:���l�ry\/��6��a��s�"ހ1h�b�G��e�qI���JD1�ZlP�1Y�L��e[n߀�;V�P��F-!��tX��e:��uK�C=}\��QX�f��(@�j��-�������z��Z+�%���~&��̀UU�[jd_���ȉ�&M�>�^#�ԆGl]��^�y�c&k�      �   H  x��UAn]7\��` Q%ޥQO�8I�.E����A���w�������=�A��p�a�5�8#�����Q,���PU&)g��:�;�8�:C2J�g>�����f}^w�i�����v�}X���~}__�'?���֧�۫�b��
�;ANCA
*���Dyvm;a��g�׭?���o�ǋ��Ҥ�8��hs:�e�u����z�s�}�JZ��:��LV�7& ���Hv���~�?9��m�JΠ��
M�� �\0c#<�r�YT��d���V
�F��	�_�u�3Hd7�]fV�,0��̄<�R�Y,Vp�_B���@#���8h?����o�\���'K�w�0p�K��T5.9�����K�#g��k`ZB7M�����{}��z���Ow]����x\��o��z$ str��ir��@�� Ň**u= �^�5�9h�Vfu��B��[���Gz��w���k���9����ŋ��l�q�fs'��9�+�JJ��[;�l4`Q�>��u��ه{ft�c{U�>�&<���MM�]���^�'&�<n�Zk���䵞>8��\,阳P8��T����a:U��;��$Y/��yxN�l�A�֏�@<�����6�ս��cr=\���N�Zd�,�Wwݺ��hYS��.�eEf�4����v*0c�H"�6w�8��)X�m�< =	��C.�T�$k<�����<_�}r7=
1�M�2N���BtWsd�j�T8�cߡ���dAC�sVl'���Fe���>#i�p4)����"6��N�dt�W^�jp�Y�ǲ��pl�\��z3	h��du�u^��7WWW? (��      �      x������ � �      �      x������ � �      �      x������ � �      �   J  x�M�AN]1E����(N��y/L��d] |�t�A��� � @P�gG��A'��_SY9�!a�.K�4:uBJ��b?��^��^�a���<�����y�|�imuC0p4 �B��F�-��V	��ۛ��ON�!���w�@�*�ZW�K>�bW�pc���3��e# EX{a82�]IU�v���r������I�[ AM�7��(�\Th+E�t�[�mo��h���(�;`��� IY!�7��4��]��<�?���������<"p�0u/�Y�M�v�����_���)�$�?#PM��e�����X�Nً=�M>]��v��;?���      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �      �      x������ � �     