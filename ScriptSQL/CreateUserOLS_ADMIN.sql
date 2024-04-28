---> Mở account lbacsys
alter user lbacsys identified by lbacsys account unlock container=all;
---> Mở PDB nếu chưa mở
alter pluggable database A08_ProjectATBM open read write; 
---> CHUYỂN QUA PDB 
alter session set container = A08_ProjectATBM; 
show con_name; 
show user;

select value from v$option where parameter = 'Oracle Label Security'; -- kiểm tra enable
select status from dba_ols_status where name = 'OLS_CONFIGURE_STATUS'; -- kiểm tra đăng ký

begin
    LBACSYS.CONFIGURE_OLS; -- This procedure registers Oracle Label Security.
    LBACSYS.OLS_ENFORCEMENT.ENABLE_OLS; -- This procedure enables it 
end;
/

---> KHỞI ĐỘNG LẠI 
shutdown immediate; 
startup; 

--Tạo user OLS_ADMIN ở PDB 
create user OLS_ADMIN identified by 123 container = current;
grant connect, resource, DBA to OLS_ADMIN;
grant unlimited tablespace to OLS_ADMIN;
grant select any dictionary to OLS_ADMIN;
grant execute on lbacsys.sa_components to OLS_ADMIN with grant option; 
grant execute on lbacsys.sa_user_admin to OLS_ADMIN with grant option; 
grant execute on lbacsys.sa_label_admin to OLS_ADMIN with grant option; 
grant execute on sa_policy_admin to OLS_ADMIN with grant option; 
grant execute on char_to_label to OLS_ADMIN with grant option; 

grant lbac_dba to OLS_ADMIN;
grant execute on sa_sysdba to OLS_ADMIN; 
grant execute on to_lbac_data_label to OLS_ADMIN;
grant execute on to_data_label to OLS_ADMIN;