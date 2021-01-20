using UnityEngine;
using System.Collections;
using LuaInterface;
using LuaFramework;

public class LuaComponent : MonoBehaviour
{
    //Lua表
    public LuaTable table;

    //添加LUA组件  
    public static LuaTable Add(GameObject go, LuaTable tableClass)
    {
        LuaFunction fun = tableClass.GetLuaFunction("New");
        if (fun == null)
            return null;

        LuaTable tab = fun.Invoke<LuaTable, LuaTable>(tableClass);
        LuaComponent cmp = go.AddComponent<LuaComponent>();
        cmp.table =  tab;
        cmp.CallAwake();
        return cmp.table;
      
    }

    //获取lua组件
    public static LuaTable Get(GameObject go, LuaTable table)
    {
        LuaComponent[] cmps = go.GetComponents<LuaComponent>();
        foreach (LuaComponent cmp in cmps)
        {
            string mat1 = table.ToString();
            string mat2 = cmp.table.GetMetaTable().ToString();
            if (mat1 == mat2) 
                return cmp.table;
        }
        return null;
    }

    //删除LUA组件的方法略，调用Destory()即可  
    void CallAwake()
    {
        LuaFunction fun = table.GetLuaFunction("Awake");
        if (fun != null)
            fun.Call(table, gameObject);
    }

    void Start()
    {
        LuaFunction fun = table.GetLuaFunction("Start");
        if (fun != null)
            fun.Call(table, gameObject);
    }

    void Update()
    {
        //效率问题有待测试和优化
        //可在lua中调用UpdateBeat替代
        LuaFunction fun = table.GetLuaFunction("Update");
        if (fun != null)
            fun.Call(table, gameObject);
    }

    void FixedUpdate()
    {
        //效率问题有待测试和优化
        //可在lua中调用UpdateBeat替代
        LuaFunction fun = table.GetLuaFunction("FixedUpdate");
        if (fun != null)
            fun.Call(table, gameObject);
    }

     void OnAnimatorMove()
    {
        LuaFunction fun = table.GetLuaFunction("OnAnimatorMove");
        if (fun != null)
            fun.Call(table, gameObject);
    }


    void OnCollisionEnter(Collision collisionInfo)
    {
        LuaFunction fun = table.GetLuaFunction("OnCollisionEnter");
        if (fun != null)
            fun.Call(table, collisionInfo);
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        LuaFunction fun = table.GetLuaFunction("OnCollisionStay");
        if (fun != null) {
            fun.Call(table, collisionInfo);
        }
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        LuaFunction fun = table.GetLuaFunction("OnCollisionExit");
        if (fun != null)
        {
            fun.Call(table, collisionInfo);
        }
    }

    void OnTriggerEnter(Collider other) {
        LuaFunction fun = table.GetLuaFunction("OnTriggerEnter");
        if (fun != null)
        {
            fun.Call(table, other);
        }
    }

    void OnTriggerStay(Collider other)
    {
        LuaFunction fun = table.GetLuaFunction("OnTriggerStay");
        if (fun != null)
        {
            fun.Call(table, other);
        }
    }

    void OnTriggerExit(Collider other)
    {
        LuaFunction fun = table.GetLuaFunction("OnTriggerExit");
        if (fun != null)
        {
            fun.Call(table, other);
        }
    }
}